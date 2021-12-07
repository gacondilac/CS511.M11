using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics.Contracts;

namespace GameCaro
{
    class GameBoard
    {
        #region Properties

        private Panel board;

        private int currentPlayer;
        private TextBox playerName;
        private PictureBox avatar;

        private List<Player> listPlayers;
        private List<List<Button>> matrixPositions;

        private event EventHandler<BtnClickEvent> playerClicked;
        private event EventHandler gameOver;

        private Stack<PlayInfo> stkUndoStep;
        private Stack<PlayInfo> stkRedoStep;

        private int playMode = 0;
        public bool IsAI = false;

        public Panel Board
        {
            get { return board; }
            set { board = value; }
        }

        public int CurrentPlayer
        {
            get { return currentPlayer; }
            set { currentPlayer = value; }
        }

        public TextBox PlayerName
        {
            get { return playerName; }
            set { playerName = value; }
        }

        public PictureBox Avatar
        {
            get { return avatar; }
            set { avatar = value; }
        }

        public List<Player> ListPlayers
        {
            get { return listPlayers; }
            set { listPlayers = value; }
        }

        public List<List<Button>> MatrixPositions
        {
            get { return matrixPositions; }
            set { matrixPositions = value; }
        }

        public event EventHandler<BtnClickEvent> PlayerClicked
        {
            add { playerClicked += value; }
            remove { playerClicked -= value; }
        }

        public event EventHandler GameOver
        {
            add { gameOver += value; }
            remove { gameOver -= value; }
        }

        public Stack<PlayInfo> StkUndoStep
        {
            get { return stkUndoStep; }
            set { stkUndoStep = value; }
        }

        public Stack<PlayInfo> StkRedoStep
        {
            get { return stkRedoStep; }
            set { stkRedoStep = value; }
        }

        public int PlayMode
        {
            get { return playMode; }
            set { playMode = value; }
        }
        #endregion

        #region Initialize
        public GameBoard(Panel board, TextBox PlayerName, PictureBox Avatar)
        {
            this.Board = board;
            this.PlayerName = PlayerName;
            this.Avatar = Avatar;

            string path_x = "\\images\\bomb_Y.png";
            string path_y = "\\images\\bomb_X.png";
            if (Constance.idxMode == 0)
            {
                path_x = "\\images\\bomb_Y.png";
                path_y = "\\images\\bomb_X.png";
            }
            else if (Constance.idxMode == 1)
            {
                path_x = "\\images\\virus_X.png";
                path_y = "\\images\\antivr_Y.png";
            }
            else if (Constance.idxMode == 2)
            {
                path_x = "\\images\\O.png";
                path_y = "\\images\\X.png";
            }
            this.CurrentPlayer = 0;
            this.ListPlayers = new List<Player>()
            {
                new Player("Player 1", Image.FromFile(Application.StartupPath + path_x),
                                        Image.FromFile(Application.StartupPath + path_x)),

                new Player("Player 2", Image.FromFile(Application.StartupPath + path_y),
                                   Image.FromFile(Application.StartupPath + path_y))
            };
        }
        #endregion

        #region Methods

        public void DrawGameBoard()
        {
            board.Enabled = true;
            board.Controls.Clear();

            StkUndoStep = new Stack<PlayInfo>();
            StkRedoStep = new Stack<PlayInfo>();

            this.CurrentPlayer = 0;
            ChangePlayer();

            int LocX, LocY;
            int nRows = Constance.nRows;
            int nCols = Constance.nCols;

            Button OldButton = new Button();
            OldButton.Width = OldButton.Height = 0;
            OldButton.Location = new Point(0, 0);

            MatrixPositions = new List<List<Button>>();

            for (int i = 0; i < nRows; i++)
            {
                MatrixPositions.Add(new List<Button>());

                for (int j = 0; j < nCols; j++)
                {
                    LocX = OldButton.Location.X + OldButton.Width;
                    LocY = OldButton.Location.Y;

                    Button btn = new Button()
                    {
                        Width = Constance.CellWidth,
                        Height = Constance.CellHeight,

                        Location = new Point(LocX, LocY),
                        Tag = i.ToString(), // Để xác định button đang ở hàng nào

                        BackColor = Color.AliceBlue,
                        BackgroundImageLayout = ImageLayout.Stretch
                    };

                    btn.Click += btn_Click;
                    MatrixPositions[i].Add(btn);

                    Board.Controls.Add(btn);
                    OldButton = btn;
                }

                OldButton.Location = new Point(0, OldButton.Location.Y + Constance.CellHeight);
                OldButton.Width = OldButton.Height = 0;
            }
        }

        private Point GetButtonCoordinate(Button btn)
        {
            int Vertical = Convert.ToInt32(btn.Tag);
            int Horizontal = MatrixPositions[Vertical].IndexOf(btn);

            Point Coordinate = new Point(Horizontal, Vertical);
            return Coordinate;
        }

        public Stack<PlayInfo> SaveGame()
        {
            return StkUndoStep;
        }

        public void StartSavedGame(Stack<PlayInfo> SavedGameNumber)
        {
            Stack<PlayInfo> temp = new Stack<PlayInfo>(SavedGameNumber.Reverse());
            int Pos_index_player = 0;
            for (int i=0; i<temp.Count; i++)
            {
                PlayInfo Pos = temp.ElementAt(i);
                this.MatrixPositions[Pos.Point.Y][Pos.Point.X].BackgroundImage = ListPlayers[Pos_index_player].Symbol;
                Pos_index_player = (Pos_index_player == 1) ? 0 : 1;
            }

            StkUndoStep = new Stack<PlayInfo>(SavedGameNumber.Reverse());
            this.CurrentPlayer = 1;
            ChangePlayer();
        }

        #region Undo & Redo
        public bool Undo()
        {
            if (StkUndoStep.Count <= 1)
                return false;

            PlayInfo OldPos = StkUndoStep.Peek();
            int temp = CurrentPlayer;
            CurrentPlayer = OldPos.CurrentPlayer == 1 ? 0 : 1;

            bool IsUndo1 = UndoAStep();
            bool IsUndo2 = UndoAStep();

            CurrentPlayer = temp;

            return IsUndo1 && IsUndo2;
        }

        private bool UndoAStep()
        {
            if (StkUndoStep.Count <= 0)
                return false;

            PlayInfo OldPos = StkUndoStep.Pop();
            StkRedoStep.Push(OldPos);

            Button btn = MatrixPositions[OldPos.Point.Y][OldPos.Point.X];
            btn.BackgroundImage = null;

            if (StkUndoStep.Count <= 0)
                CurrentPlayer = 0;

            ChangePlayer();

            return true;
        }

        public bool Redo()
        {
            if (StkRedoStep.Count <= 0)
                return false;

            PlayInfo OldPos = StkRedoStep.Peek();
            CurrentPlayer = OldPos.CurrentPlayer;

            bool IsRedo1 = RedoAStep();
            bool IsRedo2 = RedoAStep();

            return IsRedo1 && IsRedo2;
        }

        private bool RedoAStep()
        {
            if (StkRedoStep.Count <= 0)
                return false;

            PlayInfo OldPos = StkRedoStep.Pop();
            StkUndoStep.Push(OldPos);

            Button btn = MatrixPositions[OldPos.Point.Y][OldPos.Point.X];
            btn.BackgroundImage = OldPos.Symbol;

            if (StkRedoStep.Count <= 0)
                CurrentPlayer = OldPos.CurrentPlayer == 1 ? 0 : 1;
            else
                OldPos = StkRedoStep.Peek();

            ChangePlayer();

            return true;
        }
        #endregion

        #region Handling winning and losing

        void ColorButton(List<Button> lst_btn)
        {
            foreach (Button btn in lst_btn)
            {
                Point point = GetButtonCoordinate(btn);
                MatrixPositions[point.Y][point.X].BackColor = Color.Green;
            }
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetButtonCoordinate(btn);
            List<Button> lst_btn = new List<Button>();

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (MatrixPositions[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                    if (lst_btn.Count != 5)
                        lst_btn.Add(MatrixPositions[point.Y][i]);
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < Constance.nCols; i++)
            {
                if (MatrixPositions[point.Y][i].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                    if (lst_btn.Count != 5)
                        lst_btn.Add(MatrixPositions[point.Y][i]);
                }
                else
                    break;
            }

            if (lst_btn.Count == 5)
                ColorButton(lst_btn);
            lst_btn.Clear();
            return countLeft + countRight >= 5;
        }

        private bool isEndVertical(Button btn)
        {
            Point point = GetButtonCoordinate(btn);
            List<Button> lst_btn = new List<Button>();

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (MatrixPositions[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                    if (lst_btn.Count != 5)
                        lst_btn.Add(MatrixPositions[i][point.X]);
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < Constance.nRows; i++)
            {
                if (MatrixPositions[i][point.X].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                    if (lst_btn.Count != 5)
                        lst_btn.Add(MatrixPositions[i][point.X]);
                }
                else
                    break;
            }

            if (lst_btn.Count == 5)
                ColorButton(lst_btn);
            lst_btn.Clear();
            return countTop + countBottom >= 5;
        }

        private bool isEndPrimary(Button btn)
        {
            Point point = GetButtonCoordinate(btn);
            List<Button> lst_btn = new List<Button>();

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (MatrixPositions[point.Y - i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                    if (lst_btn.Count != 5)
                        lst_btn.Add(MatrixPositions[point.Y - i][point.X - i]);
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Constance.nCols - point.X; i++)
            {
                if (point.Y + i >= Constance.nRows || point.X + i >= Constance.nCols)
                    break;

                if (MatrixPositions[point.Y + i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                    if (lst_btn.Count != 5)
                        lst_btn.Add(MatrixPositions[point.Y + i][point.X + i]);
                }
                else
                    break;
            }

            if (lst_btn.Count == 5)
                ColorButton(lst_btn);
            lst_btn.Clear();
            return countTop + countBottom >= 5;
        }

        private bool isEndSub(Button btn)
        {
            Point point = GetButtonCoordinate(btn);
            List<Button> lst_btn = new List<Button>();

            int countTop = 0;
            for (int i = 0; i <= Constance.nCols; i++)
            {
                if (point.X + i >= Constance.nCols || point.Y - i < 0)
                    break;

                if (MatrixPositions[point.Y - i][point.X + i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                    if (lst_btn.Count != 5)
                        lst_btn.Add(MatrixPositions[point.Y - i][point.X + i]);
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i <= Constance.nRows; i++)
            {
                if (point.Y + i >= Constance.nRows || point.X - i < 0)
                    break;

                if (MatrixPositions[point.Y + i][point.X - i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                    if (lst_btn.Count != 5)
                        lst_btn.Add(MatrixPositions[point.Y + i][point.X - i]);
                }
                else
                    break;
            }

            if (lst_btn.Count == 5)
                ColorButton(lst_btn);
            lst_btn.Clear();
            return countTop + countBottom >= 5;
        }

        private bool IsEndGame(Button btn)
        {
            if (StkUndoStep.Count == Constance.nRows * Constance.nCols)
            {
                MessageBox.Show("Hòa cờ !!!");
                return true;
            }
            if (isEndHorizontal(btn))
                return true;
            if (isEndVertical(btn))
                return true;
            if (isEndPrimary(btn))
                return true;
            if (isEndSub(btn))
                return true;
            return false;
        }

        #endregion

        #region LAN
        public void EndGame()
        {
            if (gameOver != null)
                gameOver(this, new EventArgs());
        }

        private void ChangePlayer()
        {
            PlayerName.Text = ListPlayers[CurrentPlayer].Name;
            Avatar.Image = ListPlayers[CurrentPlayer].Avatar;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn.BackgroundImage != null)
                return; // Nếu ô đã được đánh thì ko cho đánh lại

            btn.BackgroundImage = ListPlayers[CurrentPlayer].Symbol;

            StkUndoStep.Push(new PlayInfo(GetButtonCoordinate(btn), CurrentPlayer, btn.BackgroundImage));
            StkRedoStep.Clear();

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            ChangePlayer();

            if (playerClicked != null)
                playerClicked(this, new BtnClickEvent(GetButtonCoordinate(btn)));

            if (IsEndGame(btn))
                EndGame();

            if (!(IsAI) && playMode == 3)
                StartAI();

            IsAI = false;
        }

        public void OtherPlayerClicked(Point point)
        {
            Button btn = MatrixPositions[point.Y][point.X];

            if (btn.BackgroundImage != null)
                return; // Nếu ô đã được đánh thì ko cho đánh lại

            btn.BackgroundImage = ListPlayers[CurrentPlayer].Symbol;

            StkUndoStep.Push(new PlayInfo(GetButtonCoordinate(btn), CurrentPlayer, btn.BackgroundImage));
            StkRedoStep.Clear();

            CurrentPlayer = CurrentPlayer == 1 ? 0 : 1;
            ChangePlayer();

            if (IsEndGame(btn))
                EndGame();
        }
        #endregion

        #region AI
        private long[] ArrAttackScore = new long[7] { 0, 64, 4096, 262144, 16777216, 1073741824, 68719476736 };
        private long[] ArrDefenseScore = new long[7] { 0, 8, 512, 32768, 2097152, 134217728, 8589934592 };

        #region Calculate attack score
        private long AttackHorizontal(int CurrRow, int CurrCol)
        {
            long TotalScore = 0;
            int ComCells = 0;
            int ManCells = 0;

            // Duyệt từ trên xuống
            for (int Count = 1; Count < 6 && CurrRow + Count < Constance.nRows; Count++)
            {
                if (MatrixPositions[CurrRow + Count][CurrCol].BackgroundImage == ListPlayers[0].Symbol)
                    ComCells += 1;
                else if (MatrixPositions[CurrRow + Count][CurrCol].BackgroundImage == ListPlayers[1].Symbol)
                {
                    ManCells += 1;
                    break;
                }
                else
                    break;
            }

            // Duyệt từ dưới lên
            for (int Count = 1; Count < 6 && CurrRow - Count >= 0; Count++)
            {
                if (MatrixPositions[CurrRow - Count][CurrCol].BackgroundImage == ListPlayers[0].Symbol)
                    ComCells += 1;
                else if (MatrixPositions[CurrRow - Count][CurrCol].BackgroundImage == ListPlayers[1].Symbol)
                {
                    ManCells += 1;
                    break;
                }
                else
                    break;
            }

            if (ManCells == 2)
                return 0;

            /* Nếu ManCells == 1 => bị chặn 1 đầu => lấy điểm phòng ngự tại vị trí này nhưng 
            nên cộng thêm 1 để tăng phòng ngự cho máy cảnh giác hơn vì đã bị chặn 1 đầu */

            TotalScore -= ArrDefenseScore[ManCells + 1];
            TotalScore += ArrAttackScore[ComCells];

            return TotalScore;
        }

        private long AttackVertical(int CurrRow, int CurrCol)
        {
            long TotalScore = 0;
            int ComCells = 0;
            int ManCells = 0;

            // Duyệt từ trái sang phải
            for (int Count = 1; Count < 6 && CurrCol + Count < Constance.nCols; Count++)
            {
                if (MatrixPositions[CurrRow][CurrCol + Count].BackgroundImage == ListPlayers[0].Symbol)
                    ComCells += 1;
                else if (MatrixPositions[CurrRow][CurrCol + Count].BackgroundImage == ListPlayers[1].Symbol)
                {
                    ManCells += 1;
                    break;
                }
                else
                    break;
            }

            // Duyệt từ phải sang trái
            for (int Count = 1; Count < 6 && CurrCol - Count >= 0; Count++)
            {
                if (MatrixPositions[CurrRow][CurrCol - Count].BackgroundImage == ListPlayers[0].Symbol)
                    ComCells += 1;
                else if (MatrixPositions[CurrRow][CurrCol - Count].BackgroundImage == ListPlayers[1].Symbol)
                {
                    ManCells += 1;
                    break;
                }
                else
                    break;
            }

            if (ManCells == 2)
                return 0;

            /* Nếu ManCells == 1 => bị chặn 1 đầu => lấy điểm phòng ngự tại vị trí này nhưng 
            nên cộng thêm 1 để tăng phòng ngự cho máy cảnh giác hơn vì đã bị chặn 1 đầu */

            TotalScore -= ArrDefenseScore[ManCells + 1];
            TotalScore += ArrAttackScore[ComCells];

            return TotalScore;
        }

        private long AttackMainDiag(int CurrRow, int CurrCol)
        {
            long TotalScore = 0;
            int ComCells = 0;
            int ManCells = 0;

            // Duyệt trái trên
            for (int Count = 1; Count < 6 && CurrCol + Count < Constance.nCols && CurrRow + Count < Constance.nRows; Count++)
            {
                if (MatrixPositions[CurrRow + Count][CurrCol + Count].BackgroundImage == ListPlayers[0].Symbol)
                    ComCells += 1;
                else if (MatrixPositions[CurrRow + Count][CurrCol + Count].BackgroundImage == ListPlayers[1].Symbol)
                {
                    ManCells += 1;
                    break;
                }
                else
                    break;
            }

            // Duyệt phải dưới
            for (int Count = 1; Count < 6 && CurrCol - Count >= 0 && CurrRow - Count >= 0; Count++)
            {
                if (MatrixPositions[CurrRow - Count][CurrCol - Count].BackgroundImage == ListPlayers[0].Symbol)
                    ComCells += 1;
                else if (MatrixPositions[CurrRow - Count][CurrCol - Count].BackgroundImage == ListPlayers[1].Symbol)
                {
                    ManCells += 1;
                    break;
                }
                else
                    break;
            }

            if (ManCells == 2)
                return 0;

            /* Nếu ManCells == 1 => bị chặn 1 đầu => lấy điểm phòng ngự tại vị trí này nhưng 
            nên cộng thêm 1 để tăng phòng ngự cho máy cảnh giác hơn vì đã bị chặn 1 đầu */

            TotalScore -= ArrDefenseScore[ManCells + 1];
            TotalScore += ArrAttackScore[ComCells];

            return TotalScore;
        }

        private long AttackExtraDiag(int CurrRow, int CurrCol)
        {
            long TotalScore = 0;
            int ComCells = 0;
            int ManCells = 0;

            // Duyệt phải trên
            for (int Count = 1; Count < 6 && CurrCol + Count < Constance.nCols && CurrRow - Count >= 0; Count++)
            {
                if (MatrixPositions[CurrRow - Count][CurrCol + Count].BackgroundImage == ListPlayers[0].Symbol)
                    ComCells += 1;
                else if (MatrixPositions[CurrRow - Count][CurrCol + Count].BackgroundImage == ListPlayers[1].Symbol)
                {
                    ManCells += 1;
                    break;
                }
                else
                    break;
            }

            // Duyệt trái dưới
            for (int Count = 1; Count < 6 && CurrCol - Count >= 0 && CurrRow + Count < Constance.nRows; Count++)
            {
                if (MatrixPositions[CurrRow + Count][CurrCol - Count].BackgroundImage == ListPlayers[0].Symbol)
                    ComCells += 1;
                else if (MatrixPositions[CurrRow + Count][CurrCol - Count].BackgroundImage == ListPlayers[1].Symbol)
                {
                    ManCells += 1;
                    break;
                }
                else
                    break;
            }

            if (ManCells == 2)
                return 0;

            /* Nếu ManCells == 1 => bị chặn 1 đầu => lấy điểm phòng ngự tại vị trí này nhưng 
            nên cộng thêm 1 để tăng phòng ngự cho máy cảnh giác hơn vì đã bị chặn 1 đầu */

            TotalScore -= ArrDefenseScore[ManCells + 1];
            TotalScore += ArrAttackScore[ComCells];

            return TotalScore;
        }
        #endregion

        #region Calculate defense score
        private long DefenseHorizontal(int CurrRow, int CurrCol)
        {
            long TotalScore = 0;
            int ComCells = 0;
            int ManCells = 0;

            // Duyệt từ trên xuống
            for (int Count = 1; Count < 6 && CurrRow + Count < Constance.nRows; Count++)
            {
                if (MatrixPositions[CurrRow + Count][CurrCol].BackgroundImage == ListPlayers[0].Symbol)
                {
                    ComCells += 1;
                    break;
                }
                else if (MatrixPositions[CurrRow + Count][CurrCol].BackgroundImage == ListPlayers[1].Symbol)
                    ManCells += 1;
                else
                    break;
            }

            // Duyệt từ dưới lên
            for (int Count = 1; Count < 6 && CurrRow - Count >= 0; Count++)
            {
                if (MatrixPositions[CurrRow - Count][CurrCol].BackgroundImage == ListPlayers[0].Symbol)
                {
                    ComCells += 1;
                    break;
                }
                else if (MatrixPositions[CurrRow - Count][CurrCol].BackgroundImage == ListPlayers[1].Symbol)
                    ManCells += 1;
                else
                    break;
            }

            if (ComCells == 2)
                return 0;

            TotalScore += ArrDefenseScore[ManCells];

            return TotalScore;
        }

        private long DefenseVertical(int CurrRow, int CurrCol)
        {
            long TotalScore = 0;
            int ComCells = 0;
            int ManCells = 0;

            // Duyệt từ trái sang phải
            for (int Count = 1; Count < 6 && CurrCol + Count < Constance.nCols; Count++)
            {
                if (MatrixPositions[CurrRow][CurrCol + Count].BackgroundImage == ListPlayers[0].Symbol)
                {
                    ComCells += 1;
                    break;
                }
                else if (MatrixPositions[CurrRow][CurrCol + Count].BackgroundImage == ListPlayers[1].Symbol)
                    ManCells += 1;
                else
                    break;
            }

            // Duyệt từ phải sang trái
            for (int Count = 1; Count < 6 && CurrCol - Count >= 0; Count++)
            {
                if (MatrixPositions[CurrRow][CurrCol - Count].BackgroundImage == ListPlayers[0].Symbol)
                {
                    ComCells += 1;
                    break;
                }
                else if (MatrixPositions[CurrRow][CurrCol - Count].BackgroundImage == ListPlayers[1].Symbol)
                    ManCells += 1;
                else
                    break;
            }

            if (ComCells == 2)
                return 0;

            TotalScore += ArrDefenseScore[ManCells];

            return TotalScore;
        }

        private long DefenseMainDiag(int CurrRow, int CurrCol)
        {
            long TotalScore = 0;
            int ComCells = 0;
            int ManCells = 0;

            // Duyệt trái trên
            for (int Count = 1; Count < 6 && CurrCol + Count < Constance.nCols && CurrRow + Count < Constance.nRows; Count++)
            {
                if (MatrixPositions[CurrRow + Count][CurrCol + Count].BackgroundImage == ListPlayers[0].Symbol)
                {
                    ComCells += 1;
                    break;
                }
                else if (MatrixPositions[CurrRow + Count][CurrCol + Count].BackgroundImage == ListPlayers[1].Symbol)
                    ManCells += 1;
                else
                    break;
            }

            // Duyệt phải dưới
            for (int Count = 1; Count < 6 && CurrCol - Count >= 0 && CurrRow - Count >= 0; Count++)
            {
                if (MatrixPositions[CurrRow - Count][CurrCol - Count].BackgroundImage == ListPlayers[0].Symbol)
                {
                    ComCells += 1;
                    break;
                }
                else if (MatrixPositions[CurrRow - Count][CurrCol - Count].BackgroundImage == ListPlayers[1].Symbol)
                    ManCells += 1;
                else
                    break;
            }

            if (ComCells == 2)
                return 0;

            TotalScore += ArrDefenseScore[ManCells];

            return TotalScore;
        }

        private long DefenseExtraDiag(int CurrRow, int CurrCol)
        {
            long TotalScore = 0;
            int ComCells = 0;
            int ManCells = 0;

            // Duyệt phải trên
            for (int Count = 1; Count < 6 && CurrCol + Count < Constance.nCols && CurrRow - Count >= 0; Count++)
            {
                if (MatrixPositions[CurrRow - Count][CurrCol + Count].BackgroundImage == ListPlayers[0].Symbol)
                {
                    ComCells += 1;
                    break;
                }
                else if (MatrixPositions[CurrRow - Count][CurrCol + Count].BackgroundImage == ListPlayers[1].Symbol)
                    ManCells += 1;
                else
                    break;
            }

            // Duyệt trái dưới
            for (int Count = 1; Count < 6 && CurrCol - Count >= 0 && CurrRow + Count < Constance.nRows; Count++)
            {
                if (MatrixPositions[CurrRow + Count][CurrCol - Count].BackgroundImage == ListPlayers[0].Symbol)
                {
                    ComCells += 1;
                    break;
                }
                else if (MatrixPositions[CurrRow + Count][CurrCol - Count].BackgroundImage == ListPlayers[1].Symbol)
                    ManCells += 1;
                else
                    break;
            }

            if (ComCells == 2)
                return 0;

            TotalScore += ArrDefenseScore[ManCells];

            return TotalScore;
        }
        #endregion

        #region AI mark
        private Point FindAiPos()
        {
            Point AiPos = new Point();
            long MaxScore = 0;

            for (int i = 0; i < Constance.nRows; i++)
            {
                for (int j = 0; j < Constance.nCols; j++)
                {
                    if (MatrixPositions[i][j].BackgroundImage == null)
                    {
                        long AttackScore = AttackHorizontal(i, j) + AttackVertical(i, j) + AttackMainDiag(i, j) + AttackExtraDiag(i, j);
                        long DefenseScore = DefenseHorizontal(i, j) + DefenseVertical(i, j) + DefenseMainDiag(i, j) + DefenseExtraDiag(i, j);
                        long TempScore = AttackScore > DefenseScore ? AttackScore : DefenseScore;

                        if (MaxScore < TempScore)
                        {
                            MaxScore = TempScore;
                            AiPos = new Point(i, j);
                        }
                    }
                }
            }

            return AiPos;
        }

        public void StartAI()
        {
            IsAI = true;
            // mới bắt đầu thì cho đánh giữa bàn cờ
            if (StkUndoStep.Count == 0)
            {
                MatrixPositions[6][7].PerformClick();
            }
            else
            {
                Point AiPos = FindAiPos();
                MatrixPositions[AiPos.X][AiPos.Y].PerformClick();
            }
        }
        #endregion

        #endregion

        #endregion
    }

    public class BtnClickEvent : EventArgs
    {
        private Point clickedPoint;

        public Point ClickedPoint
        {
            get { return clickedPoint; }
            set { clickedPoint = value; }
        }

        public BtnClickEvent(Point point)
        {
            this.ClickedPoint = point;
        }
    }

}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.NetworkInformation;
using System.Threading;
using System.Media;

namespace GameCaro
{
    public partial class frmLAN : Form
    {
        #region Properties

        GameBoard board;
        SocketManager socket;
        string PlayerName;
        int IsConnected = 0;

        #endregion

        #region Initialize
        public frmLAN()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            board = new GameBoard(pn_GameBoard, txt_PlayerName, pb_Avatar);
            board.PlayerClicked += Board_PlayerClicked;
            board.GameOver += Board_GameOver;

            pgb_CountDown.Step = Constance.CountDownStep;
            pgb_CountDown.Maximum = Constance.CountDownTime;

            tm_CountDown.Interval = Constance.CountDownInterval;
            socket = new SocketManager();

            txt_Chat.Text = "";

            if (Constance.idxMode == 0)
            {
                pn_GameBoard.BackColor = Color.Linen;
                btn_Redo.BackColor = Color.PeachPuff;
                btn_Undo.BackColor = Color.PeachPuff;
                btn_LAN.BackColor = Color.PeachPuff;
                btn_LAN.ForeColor = Color.Crimson;
                txt_PlayerName.BackColor = Color.PeachPuff;
                txt_IP.BackColor = Color.PeachPuff;
                label2.ForeColor = Color.PeachPuff;
                label1.BackColor = Color.PeachPuff;
                txt_Chat.BackColor = Color.Linen;
                txt_Message.BackColor = Color.PeachPuff;
                logo.BackgroundImage = global::GameCaro.Properties.Resources.hat_noel_;
                BackgroundImage = global::GameCaro.Properties.Resources.noel;
                pn_infor.BackgroundImage = global::GameCaro.Properties.Resources.noel1;
                btn_Redo.BackgroundImage = global::GameCaro.Properties.Resources.redo__;
                btn_Undo.BackgroundImage = global::GameCaro.Properties.Resources.undo_;
            }
            else if (Constance.idxMode == 1)
            {
                pn_GameBoard.BackColor = Color.PowderBlue;
                btn_Redo.BackColor = Color.PowderBlue;
                btn_Undo.BackColor = Color.PowderBlue;
                btn_LAN.BackColor = Color.PowderBlue;
                btn_LAN.ForeColor = Color.Tomato;
                txt_PlayerName.BackColor = Color.PowderBlue;
                txt_IP.BackColor = Color.PowderBlue;
                label2.ForeColor = Color.PowderBlue;
                label1.BackColor = Color.PowderBlue;
                txt_Chat.BackColor = Color.PowderBlue;
                logo.BackgroundImage = global::GameCaro.Properties.Resources._5k;
                BackgroundImage = global::GameCaro.Properties.Resources.Download_free_vector_of_Clean_medical_patterned_background_vector_by_marinemynt_about_medicine__health__pharmacy__medical_background__and_pharmacy_background_2292666;
                pn_infor.BackgroundImage = global::GameCaro.Properties.Resources.Download_free_vector_of_Coronavirus_medical_equipment_element_set_vector_by_Tang_about_teeth__teeth_vector__clinic__medicine_icon__and_hospital_2292431;
                btn_Redo.BackgroundImage = global::GameCaro.Properties.Resources.redo1;
                btn_Undo.BackgroundImage = global::GameCaro.Properties.Resources.undo1;
            }
            else if (Constance.idxMode == 2)
            {
                pn_GameBoard.BackColor = Color.PowderBlue;
                btn_Redo.BackColor = Color.PowderBlue;
                btn_Undo.BackColor = Color.PowderBlue;
                btn_LAN.BackColor = Color.PowderBlue;
                btn_LAN.ForeColor = Color.Tomato;
                txt_PlayerName.BackColor = Color.PowderBlue;
                txt_IP.BackColor = Color.PowderBlue;
                label2.ForeColor = Color.PowderBlue;
                label1.BackColor = Color.PowderBlue;
                logo.BackgroundImage = global::GameCaro.Properties.Resources.logotraicay;
                BackgroundImage = global::GameCaro.Properties.Resources.traicay;
                pn_infor.BackgroundImage = global::GameCaro.Properties.Resources.traicay1;
                btn_Redo.BackgroundImage = global::GameCaro.Properties.Resources.redo1;
                btn_Undo.BackgroundImage = global::GameCaro.Properties.Resources.undo1;
                //insert code here to add mode
            }

            btn_Send.Enabled = false;
            txt_Message.Enabled = false;
            pn_GameBoard.Enabled = false;
        }

        #endregion

        #region Method

        void NewGame()
        {
            pgb_CountDown.Value = 0;
            tm_CountDown.Stop();

            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            btn_Undo.Enabled = false;
            btn_Redo.Enabled = false;

            board.DrawGameBoard();
        }

        void EndGame()
        {
            undoToolStripMenuItem.Enabled = false;
            redoToolStripMenuItem.Enabled = false;

            btn_Undo.Enabled = false;
            btn_Redo.Enabled = false;

            tm_CountDown.Stop();
            Timing.Stop();
            
            pn_GameBoard.Enabled = false;
        }

        private void GameCaro_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc muốn thoát không?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != System.Windows.Forms.DialogResult.Yes)
                e.Cancel = true;
            else
            {
                try
                {
                    Timing.Stop();
                    SoundBG();
                    socket.Send(new SocketData((int)SocketCommand.QUIT, "", new Point()));
                }
                catch { }
            }
        }

        private void Tm_CountDown_Tick(object sender, EventArgs e)
        {
            pgb_CountDown.PerformStep();

            if (pgb_CountDown.Value >= pgb_CountDown.Maximum)
            {
                Timing.Stop();
                EndGame();
                if (board.PlayMode == 1)
                    socket.Send(new SocketData((int)SocketCommand.TIME_OUT, "", new Point()));
                SoundTimeup();
            }
        }

        #region Event call from class GameBoard
        private void Board_PlayerClicked(object sender, BtnClickEvent e)
        {
            tm_CountDown.Start();
            SoundTiming();
            pgb_CountDown.Value = 0;

            if (board.PlayMode == 1)
            {
                try
                {
                    pn_GameBoard.Enabled = false;
                    socket.Send(new SocketData((int)SocketCommand.SEND_POINT, "", e.ClickedPoint));

                    undoToolStripMenuItem.Enabled = false;
                    redoToolStripMenuItem.Enabled = false;

                    btn_Undo.Enabled = false;
                    btn_Redo.Enabled = false;

                    Listen();
                }
                catch
                {
                    EndGame();
                    MessageBox.Show("Không có kết nối nào tới máy đối thủ", "Lỗi kết nối", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Board_GameOver(object sender, EventArgs e)
        {
            EndGame();
            SoundWin();
            if (board.PlayMode == 1)
                socket.Send(new SocketData((int)SocketCommand.END_GAME, "", new Point()));
        }
        #endregion

        #region MenuStrip

        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timing.Stop();
            NewGame();
            
            if (board.PlayMode == 1)
            {
                try
                {
                    socket.Send(new SocketData((int)SocketCommand.NEW_GAME, "", new Point()));
                }
                catch { }
            }

            pn_GameBoard.Enabled = true;
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgb_CountDown.Value = 0;
            board.Undo();

            if (board.PlayMode == 1)
                socket.Send(new SocketData((int)SocketCommand.UNDO, "", new Point()));
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pgb_CountDown.Value = 0;
            board.Redo();

            if (board.PlayMode == 1)
                socket.Send(new SocketData((int)SocketCommand.REDO, "", new Point()));
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timing.Stop();
            this.Close();
        }

        #endregion

        #region Button

        private void Btn_LAN_Click(object sender, EventArgs e)
        {
            if (IsConnected == 0)
            {
                board.PlayMode = 1;
                NewGame();

                socket.IP = txt_IP.Text;

                if (!socket.ConnectServer())
                {
                    socket.IsServer = true;
                    pn_GameBoard.Enabled = false;
                    socket.CreateServer(pn_GameBoard, txt_Message, btn_Send, btn_LAN);
                }
                else
                {
                    socket.IsServer = false;
                    pn_GameBoard.Enabled = false;
                    txt_Message.Enabled = true;
                    btn_Send.Enabled = true;
                    btn_LAN.Text = "Connected";
                    MessageBox.Show("Kết nối thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Listen();
                }

                btn_LAN.Enabled = false;
                IsConnected = 1;
            }
        }

        private void Btn_Undo_Click(object sender, EventArgs e)
        {
            UndoToolStripMenuItem_Click(sender, e);
        }

        private void Btn_Redo_Click(object sender, EventArgs e)
        {
            RedoToolStripMenuItem_Click(sender, e);
        }

        private void Btn_Send_Click(object sender, EventArgs e)
        {
            if (board.PlayMode != 1)
                return;

            PlayerName = board.ListPlayers[socket.IsServer ? 0 : 1].Name;
            txt_Chat.Text += "- " + PlayerName + ": " + txt_Message.Text + "\r\n";

            socket.Send(new SocketData((int)SocketCommand.SEND_MESSAGE, txt_Chat.Text, new Point()));
            txt_Message.Text = "";
            Listen();
        }

        #endregion

        #region LAN settings
        private void GameCaro_Shown(object sender, EventArgs e)
        {
            pn_GameBoard.Enabled = false;
            btn_Undo.Enabled = false;
            btn_Redo.Enabled = false;
            btn_Send.Enabled = false;
            txt_Message.Enabled = false;
            txt_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Wireless80211);

            if (string.IsNullOrEmpty(txt_IP.Text))
                txt_IP.Text = socket.GetLocalIPv4(NetworkInterfaceType.Ethernet);
        }

        private void Listen()
        {
            Thread ListenThread = new Thread(() =>
            {
                try
                {
                    SocketData data = (SocketData)socket.Receive();
                    ProcessData(data);
                }
                catch { }
            });

            ListenThread.IsBackground = true;
            ListenThread.Start();
        }

        private void ProcessData(SocketData data)
        {
            PlayerName = board.ListPlayers[board.CurrentPlayer == 1 ? 0 : 1].Name;

            switch (data.Command)
            {
                case (int)SocketCommand.SEND_POINT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        board.OtherPlayerClicked(data.Point);
                        pn_GameBoard.Enabled = true;

                        pgb_CountDown.Value = 0;
                        tm_CountDown.Start();

                        undoToolStripMenuItem.Enabled = true;
                        redoToolStripMenuItem.Enabled = true;

                        btn_Undo.Enabled = true;
                        btn_Redo.Enabled = true;
                    }));
                    break;

                case (int)SocketCommand.SEND_MESSAGE:
                    txt_Chat.Text = data.Message;
                    break;

                case (int)SocketCommand.NEW_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        NewGame();
                        pn_GameBoard.Enabled = false;
                    }));
                    break;

                case (int)SocketCommand.UNDO:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        pgb_CountDown.Value = 0;
                        board.Undo();
                    }));
                    break;

                case (int)SocketCommand.REDO:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        // pgb_CountDown.Value = 0;
                        board.Redo();
                    }));
                    break;

                case (int)SocketCommand.END_GAME:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                        MessageBox.Show(PlayerName + " đã chiến thắng !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;

                case (int)SocketCommand.TIME_OUT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        EndGame();
                        MessageBox.Show("Hết giờ !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;

                case (int)SocketCommand.QUIT:
                    this.Invoke((MethodInvoker)(() =>
                    {
                        tm_CountDown.Stop();
                        pgb_CountDown.Value = 0;
                        EndGame();

                        board.PlayMode = 2;
                        socket.CloseConnect();

                        MessageBox.Show("Đối thủ đã rời trận!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }));
                    break;

                default:
                    break;
            }

            Listen();
        }

        #endregion

        #endregion

        #region sound
        SoundPlayer Timing = new SoundPlayer();
        private void SoundTiming()
        {
            string path = Application.StartupPath + "\\tiktac.wav";
            Timing.SoundLocation = path;
            Timing.Load();
            if (Constance.idxsound == 0)
                Timing.PlayLooping();
        }
        SoundPlayer TimeUp = new SoundPlayer();
        private void SoundTimeup()
        {
            string path = Application.StartupPath + "\\time_up.wav";
            TimeUp.SoundLocation = path;
            TimeUp.Load();
            if (Constance.idxsound == 0)
                TimeUp.Play();
        }
        SoundPlayer smusic = new SoundPlayer();
        private void SoundBG()
        {
            string path = Application.StartupPath + "\\nhacnen.wav";
            smusic.SoundLocation = path;
            smusic.Load();
            if (Constance.idxmusic == 0)
                smusic.PlayLooping();

        }
        SoundPlayer win = new SoundPlayer();
        private void SoundWin()
        {
            string path = Application.StartupPath + "\\win.wav";
            win.SoundLocation = path;
            win.Load();
            win.Play();

        }
        #endregion
    }
}

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
    public partial class frmComputer : Form
    {
        #region Properties

        GameBoard board;
        bool OpenSavedGame = false;

        #endregion

        #region Initialize

        public frmComputer()
        {
            InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;

            board = new GameBoard(pn_GameBoard, txt_PlayerName, pb_Avatar);
            board.PlayerClicked += Board_PlayerClicked;
            board.GameOver += Board_GameOver;

            pgb_CountDown.Step = Constance.CountDownStep;
            pgb_CountDown.Maximum = Constance.CountDownTime;

            tm_CountDown.Interval = Constance.CountDownInterval;

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
            NewGame();
        }

        #endregion

        #region Method

        private void FormShown(object sender, EventArgs e)
        {
            if (Program.OpenSavedGame == false)
            {
                board.IsAI = true;
                board.PlayMode = 3;
                board.StartAI();
            }
            else
            {
                board.IsAI = false;
                board.PlayMode = 3;
                board.StartSavedGame(Program.GameSaved);
                OpenSavedGame = Program.OpenSavedGame;
                Program.OpenSavedGame = false;
            }
        } // Start AI Mode

        void NewGame()
        {
            pgb_CountDown.Value = 0;
            tm_CountDown.Stop();

            undoToolStripMenuItem.Enabled = true;
            redoToolStripMenuItem.Enabled = true;

            btn_Undo.Enabled = true;
            btn_Redo.Enabled = true;

            board.DrawGameBoard();

            board.IsAI = true;
            board.PlayMode = 3;
            board.StartAI();
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

        private void frmComputer_FormClosed(object sender, FormClosedEventArgs e)
        {
            Timing.Stop();
            SoundBG();
        }

        private void Board_PlayerClicked(object sender, BtnClickEvent e)
        {
            tm_CountDown.Start();
            //sound
            SoundTiming();
            pgb_CountDown.Value = 0;
        } // Event after click a button

        private void Board_GameOver(object sender, EventArgs e)
        {
            EndGame();
            SoundWin();
            Program.GameSaved = new Stack<PlayInfo>();
        }

        private void Tm_CountDown_Tick(object sender, EventArgs e)
        {
            pgb_CountDown.PerformStep();

            if (pgb_CountDown.Value >= pgb_CountDown.Maximum)
            {
                // Time out....sound!
                Timing.Stop();
                EndGame();
                SoundTimeup();
            }
        }

        #region MenuStrip
        private void NewGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
            //sound
            SoundTiming();

            pn_GameBoard.Enabled = true;

        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pgb_CountDown.Value = 0;
            board.Undo();
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // pgb_CountDown.Value = 0;
            board.Redo();
        }

        private void QuitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timing.Stop();
            this.Close();
        }
        #endregion

        #region Button
        private void Btn_Undo_Click(object sender, EventArgs e)
        {
            UndoToolStripMenuItem_Click(sender, e);
        }

        private void Btn_Redo_Click(object sender, EventArgs e)
        {
            RedoToolStripMenuItem_Click(sender, e);
        }

        private void btn_SaveGame_Click(object sender, EventArgs e)
        {
            Stack<PlayInfo> temp = board.SaveGame();
            Program.GameSaved = new Stack<PlayInfo>(temp.Reverse());
            MessageBox.Show("Game Saved");
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

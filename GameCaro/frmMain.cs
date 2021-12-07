using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace GameCaro
{
    public partial class frmMain : Form
    {
        #region Properties
        SoundPlayer smusic = new SoundPlayer();
        int pim = 1;
        int pis = 1;
        #endregion

        #region Initialize
        public frmMain()
        {
            InitializeComponent();
            SoundBG();
        }
        #endregion

        #region Method

        private void frmMain_Shown(object sender, EventArgs e)
        {
            SoundBG();
        }

        private void btn_Computer_Click(object sender, EventArgs e)
        {
            pn_computer.Visible = true;
            btn_Computer.Visible = false;
            btn_Back.Visible = true;

            if (Program.GameSaved.Count > 1)
                btn_Continue.Visible = true;
            else
                btn_Continue.Visible = false;
        }

        private void btn_LAN_Click(object sender, EventArgs e)
        {
            smusic.Stop();
            this.Hide();
            frmLAN f = new frmLAN();
            f.Show();
            f.Closed += (s, args) => this.Show();
        }

        private void btn_Setting_Click(object sender, EventArgs e)
        {
            pn_setting.Visible = true;
            pn_main.Visible = false;
            btn_About.Visible = false;
            btn_Back.Visible = false;
        }

        private void btn_About_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAbout f = new frmAbout();
            btn_Back.Visible = false;
            f.Show();
            f.Closed += (s, args) => this.Show();
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            pn_main.Visible = true;
            pn_computer.Visible = false;
            pn_setting.Visible = false;
            btn_Back.Visible = false;

            btn_Computer.Visible = true;
            btn_LAN.Visible = true;
            btn_Setting.Visible = true;
            btn_About.Visible = true;
        }

        private void SoundBG()
        {
            string path = Application.StartupPath + "\\nhacnen.wav";
            smusic.SoundLocation = path;
            smusic.Load();
            if (Constance.idxmusic == 0)
                smusic.PlayLooping();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //new
            smusic.Stop();
            this.Hide();
            frmComputer f = new frmComputer();
            f.Show();
            f.Closed += (s, args) => this.Show();

            pn_main.Visible = true;
            pn_computer.Visible = false;
            pn_setting.Visible = false;
            btn_Back.Visible = false;

            btn_Computer.Visible = true;
            btn_LAN.Visible = true;
            btn_Setting.Visible = true;
            btn_About.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //continue
            smusic.Stop();
            Program.OpenSavedGame = true;
            this.Hide();
            frmComputer f = new frmComputer();
            f.Show();
            f.Closed += (s, args) => this.Show();

            pn_main.Visible = true;
            pn_computer.Visible = false;
            pn_setting.Visible = false;
            btn_Back.Visible = false;

            btn_Computer.Visible = true;
            btn_LAN.Visible = true;
            btn_Setting.Visible = true;
            btn_About.Visible = true;
        }

        private void music_Click(object sender, EventArgs e)
        {
            if (pim == 1)
            {
                music.Image = global::GameCaro.Properties.Resources.mute;
                smusic.Stop();
                pim = 0;
                Constance.idxmusic = 1;
            }
            else
            {
                music.Image = null;
                Constance.idxmusic = 0;
                SoundBG();
                pim = 1;
            }
        }

        private void sound_Click(object sender, EventArgs e)
        {
            if (pis == 1)
            {
                Constance.idxsound = 1;
                sound.Image = global::GameCaro.Properties.Resources.mute;
                pis = 0;
            }
            else
            {
                Constance.idxsound = 0;
                sound.Image = null;
                pis = 1;
            }
        }

        private void back_setting_Click(object sender, EventArgs e)
        {
            pn_main.Visible = true;
            pn_setting.Visible = false;
            btn_About.Visible = true;
            btn_Back.Visible = false;
            if (cbb_mode.Text == "Noel")
            {
                Constance.idxMode = 0;
            }
            else
                if (cbb_mode.Text == "Covid")
            {
                Constance.idxMode = 1;
            }
            else
                if (cbb_mode.Text == "Fruit")
            {
                Constance.idxMode = 2;
            }
        }
        #endregion
    }
}

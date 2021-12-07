
namespace GameCaro
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.button3 = new System.Windows.Forms.Button();
            this.pn_main = new System.Windows.Forms.Panel();
            this.pn_computer = new System.Windows.Forms.Panel();
            this.btn_Continue = new System.Windows.Forms.Button();
            this.btn_NewGame = new System.Windows.Forms.Button();
            this.btn_Computer = new System.Windows.Forms.Button();
            this.btn_About = new System.Windows.Forms.Button();
            this.btn_LAN = new System.Windows.Forms.Button();
            this.btn_Setting = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.back_setting = new System.Windows.Forms.Button();
            this.cbb_mode = new MaterialSurface.MaterialComboBox();
            this.button4 = new System.Windows.Forms.Button();
            this.pn_setting = new System.Windows.Forms.Panel();
            this.music = new System.Windows.Forms.Button();
            this.sound = new System.Windows.Forms.Button();
            this.btn_Back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pn_main.SuspendLayout();
            this.pn_computer.SuspendLayout();
            this.pn_setting.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(4, 108);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 44);
            this.button3.TabIndex = 23;
            this.button3.Text = "Music";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // pn_main
            // 
            this.pn_main.Controls.Add(this.pn_computer);
            this.pn_main.Controls.Add(this.btn_Computer);
            this.pn_main.Controls.Add(this.btn_About);
            this.pn_main.Controls.Add(this.btn_LAN);
            this.pn_main.Controls.Add(this.btn_Setting);
            this.pn_main.Location = new System.Drawing.Point(49, 190);
            this.pn_main.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_main.Name = "pn_main";
            this.pn_main.Size = new System.Drawing.Size(368, 337);
            this.pn_main.TabIndex = 26;
            // 
            // pn_computer
            // 
            this.pn_computer.Controls.Add(this.btn_Continue);
            this.pn_computer.Controls.Add(this.btn_NewGame);
            this.pn_computer.Location = new System.Drawing.Point(68, 37);
            this.pn_computer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_computer.Name = "pn_computer";
            this.pn_computer.Size = new System.Drawing.Size(236, 239);
            this.pn_computer.TabIndex = 20;
            this.pn_computer.Visible = false;
            // 
            // btn_Continue
            // 
            this.btn_Continue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Continue.FlatAppearance.BorderSize = 0;
            this.btn_Continue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Continue.Font = new System.Drawing.Font("Forte", 16.2F);
            this.btn_Continue.ForeColor = System.Drawing.Color.White;
            this.btn_Continue.Location = new System.Drawing.Point(37, 66);
            this.btn_Continue.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Continue.Name = "btn_Continue";
            this.btn_Continue.Size = new System.Drawing.Size(168, 41);
            this.btn_Continue.TabIndex = 1;
            this.btn_Continue.Text = "Comtinue";
            this.btn_Continue.UseVisualStyleBackColor = true;
            this.btn_Continue.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_NewGame
            // 
            this.btn_NewGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_NewGame.FlatAppearance.BorderSize = 0;
            this.btn_NewGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NewGame.Font = new System.Drawing.Font("Forte", 16.2F);
            this.btn_NewGame.ForeColor = System.Drawing.Color.White;
            this.btn_NewGame.Location = new System.Drawing.Point(37, 5);
            this.btn_NewGame.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_NewGame.Name = "btn_NewGame";
            this.btn_NewGame.Size = new System.Drawing.Size(168, 46);
            this.btn_NewGame.TabIndex = 0;
            this.btn_NewGame.Text = "New Game";
            this.btn_NewGame.UseVisualStyleBackColor = true;
            this.btn_NewGame.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Computer
            // 
            this.btn_Computer.BackColor = System.Drawing.Color.Transparent;
            this.btn_Computer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Computer.FlatAppearance.BorderSize = 0;
            this.btn_Computer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.btn_Computer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.btn_Computer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Computer.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Computer.ForeColor = System.Drawing.Color.White;
            this.btn_Computer.Location = new System.Drawing.Point(101, 37);
            this.btn_Computer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Computer.Name = "btn_Computer";
            this.btn_Computer.Size = new System.Drawing.Size(168, 54);
            this.btn_Computer.TabIndex = 15;
            this.btn_Computer.Text = "Computer";
            this.btn_Computer.UseVisualStyleBackColor = false;
            this.btn_Computer.Click += new System.EventHandler(this.btn_Computer_Click);
            // 
            // btn_About
            // 
            this.btn_About.BackColor = System.Drawing.Color.Transparent;
            this.btn_About.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_About.FlatAppearance.BorderSize = 0;
            this.btn_About.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.btn_About.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.btn_About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_About.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_About.ForeColor = System.Drawing.Color.White;
            this.btn_About.Location = new System.Drawing.Point(101, 222);
            this.btn_About.Margin = new System.Windows.Forms.Padding(4);
            this.btn_About.Name = "btn_About";
            this.btn_About.Size = new System.Drawing.Size(168, 54);
            this.btn_About.TabIndex = 18;
            this.btn_About.Text = "About";
            this.btn_About.UseVisualStyleBackColor = false;
            this.btn_About.Click += new System.EventHandler(this.btn_About_Click);
            // 
            // btn_LAN
            // 
            this.btn_LAN.BackColor = System.Drawing.Color.Transparent;
            this.btn_LAN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_LAN.FlatAppearance.BorderSize = 0;
            this.btn_LAN.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.btn_LAN.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.btn_LAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LAN.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LAN.ForeColor = System.Drawing.Color.White;
            this.btn_LAN.Location = new System.Drawing.Point(101, 98);
            this.btn_LAN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LAN.Name = "btn_LAN";
            this.btn_LAN.Size = new System.Drawing.Size(168, 54);
            this.btn_LAN.TabIndex = 16;
            this.btn_LAN.Text = "LAN";
            this.btn_LAN.UseVisualStyleBackColor = false;
            this.btn_LAN.Click += new System.EventHandler(this.btn_LAN_Click);
            // 
            // btn_Setting
            // 
            this.btn_Setting.BackColor = System.Drawing.Color.Transparent;
            this.btn_Setting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Setting.FlatAppearance.BorderSize = 0;
            this.btn_Setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.btn_Setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.btn_Setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Setting.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Setting.ForeColor = System.Drawing.Color.White;
            this.btn_Setting.Location = new System.Drawing.Point(101, 160);
            this.btn_Setting.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Setting.Name = "btn_Setting";
            this.btn_Setting.Size = new System.Drawing.Size(168, 54);
            this.btn_Setting.TabIndex = 17;
            this.btn_Setting.Text = "Setting";
            this.btn_Setting.UseVisualStyleBackColor = false;
            this.btn_Setting.Click += new System.EventHandler(this.btn_Setting_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Transparent;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(4, 46);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(93, 44);
            this.button5.TabIndex = 24;
            this.button5.Text = "Sound";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // back_setting
            // 
            this.back_setting.BackColor = System.Drawing.Color.Transparent;
            this.back_setting.FlatAppearance.BorderSize = 0;
            this.back_setting.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.back_setting.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.back_setting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_setting.Font = new System.Drawing.Font("Forte", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_setting.ForeColor = System.Drawing.Color.White;
            this.back_setting.Location = new System.Drawing.Point(83, 262);
            this.back_setting.Margin = new System.Windows.Forms.Padding(4);
            this.back_setting.Name = "back_setting";
            this.back_setting.Size = new System.Drawing.Size(204, 54);
            this.back_setting.TabIndex = 22;
            this.back_setting.Text = "Done";
            this.back_setting.UseVisualStyleBackColor = false;
            this.back_setting.Click += new System.EventHandler(this.back_setting_Click);
            // 
            // cbb_mode
            // 
            this.cbb_mode.AutoSizing = false;
            this.cbb_mode.BackColor = System.Drawing.Color.Transparent;
            this.cbb_mode.ComboBoxType = MaterialSurface.BoxType.Normal;
            this.cbb_mode.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbb_mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbb_mode.DropDownWidth = 121;
            this.cbb_mode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbb_mode.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbb_mode.ForeColor = System.Drawing.Color.White;
            this.cbb_mode.FormattingEnabled = true;
            this.cbb_mode.HintText = "";
            this.cbb_mode.ItemHeight = 42;
            this.cbb_mode.Items.AddRange(new object[] {
            "Noel",
            "Covid",
            "Fruit"});
            this.cbb_mode.Location = new System.Drawing.Point(209, 160);
            this.cbb_mode.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbb_mode.MaxDropDownItems = 4;
            this.cbb_mode.MouseState = MaterialSurface.MouseState.OUT;
            this.cbb_mode.Name = "cbb_mode";
            this.cbb_mode.PrimaryColor = System.Drawing.Color.LightCyan;
            this.cbb_mode.Size = new System.Drawing.Size(108, 48);
            this.cbb_mode.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Transparent;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(32)))), ((int)(((byte)(108)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Forte", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(4, 175);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(93, 44);
            this.button4.TabIndex = 20;
            this.button4.Text = "Mode";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // pn_setting
            // 
            this.pn_setting.Controls.Add(this.button5);
            this.pn_setting.Controls.Add(this.button3);
            this.pn_setting.Controls.Add(this.back_setting);
            this.pn_setting.Controls.Add(this.cbb_mode);
            this.pn_setting.Controls.Add(this.button4);
            this.pn_setting.Controls.Add(this.music);
            this.pn_setting.Controls.Add(this.sound);
            this.pn_setting.Location = new System.Drawing.Point(49, 190);
            this.pn_setting.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pn_setting.Name = "pn_setting";
            this.pn_setting.Size = new System.Drawing.Size(368, 337);
            this.pn_setting.TabIndex = 25;
            this.pn_setting.Visible = false;
            // 
            // music
            // 
            this.music.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("music.BackgroundImage")));
            this.music.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.music.FlatAppearance.BorderSize = 0;
            this.music.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.music.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.music.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.music.Location = new System.Drawing.Point(209, 103);
            this.music.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.music.Name = "music";
            this.music.Size = new System.Drawing.Size(60, 49);
            this.music.TabIndex = 1;
            this.music.UseVisualStyleBackColor = true;
            this.music.Click += new System.EventHandler(this.music_Click);
            // 
            // sound
            // 
            this.sound.BackColor = System.Drawing.Color.Transparent;
            this.sound.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sound.BackgroundImage")));
            this.sound.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.sound.FlatAppearance.BorderSize = 0;
            this.sound.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.sound.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.sound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sound.Location = new System.Drawing.Point(209, 42);
            this.sound.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(69, 49);
            this.sound.TabIndex = 0;
            this.sound.UseVisualStyleBackColor = false;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Back.BackgroundImage = global::GameCaro.Properties.Resources.Undo_Main;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(51, 33);
            this.btn_Back.TabIndex = 27;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Visible = false;
            this.btn_Back.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::GameCaro.Properties.Resources._566294;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(151, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 154);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(463, 546);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.pn_main);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pn_setting);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Caro";
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.pn_main.ResumeLayout(false);
            this.pn_computer.ResumeLayout(false);
            this.pn_setting.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Back;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel pn_main;
        private System.Windows.Forms.Panel pn_computer;
        private System.Windows.Forms.Button btn_Continue;
        private System.Windows.Forms.Button btn_NewGame;
        private System.Windows.Forms.Button btn_Computer;
        private System.Windows.Forms.Button btn_About;
        private System.Windows.Forms.Button btn_LAN;
        private System.Windows.Forms.Button btn_Setting;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button back_setting;
        private MaterialSurface.MaterialComboBox cbb_mode;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button music;
        private System.Windows.Forms.Button sound;
        private System.Windows.Forms.Panel pn_setting;
    }
}
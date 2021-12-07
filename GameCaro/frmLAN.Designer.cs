
namespace GameCaro
{
    partial class frmLAN
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLAN));
            this.txt_Message = new System.Windows.Forms.RichTextBox();
            this.tm_CountDown = new System.Windows.Forms.Timer(this.components);
            this.btn_Send = new System.Windows.Forms.Button();
            this.pn_infor = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_PlayerName = new System.Windows.Forms.TextBox();
            this.pgb_CountDown = new System.Windows.Forms.ProgressBar();
            this.pb_Avatar = new System.Windows.Forms.PictureBox();
            this.txt_IP = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.logo = new System.Windows.Forms.PictureBox();
            this.txt_Chat = new System.Windows.Forms.RichTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pn_GameBoard = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_Back = new System.Windows.Forms.Button();
            this.btn_LAN = new GameCaro.myButton();
            this.btn_Redo = new GameCaro.myButton();
            this.btn_Undo = new GameCaro.myButton();
            this.pn_infor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Message
            // 
            this.txt_Message.BackColor = System.Drawing.Color.SkyBlue;
            this.txt_Message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Message.Location = new System.Drawing.Point(772, 562);
            this.txt_Message.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Message.Name = "txt_Message";
            this.txt_Message.Size = new System.Drawing.Size(215, 38);
            this.txt_Message.TabIndex = 37;
            this.txt_Message.Text = "";
            // 
            // tm_CountDown
            // 
            this.tm_CountDown.Tick += new System.EventHandler(this.Tm_CountDown_Tick);
            // 
            // btn_Send
            // 
            this.btn_Send.BackColor = System.Drawing.Color.Transparent;
            this.btn_Send.BackgroundImage = global::GameCaro.Properties.Resources.Send;
            this.btn_Send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Send.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Send.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send.ForeColor = System.Drawing.Color.White;
            this.btn_Send.Location = new System.Drawing.Point(996, 562);
            this.btn_Send.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Send.Name = "btn_Send";
            this.btn_Send.Size = new System.Drawing.Size(89, 39);
            this.btn_Send.TabIndex = 34;
            this.btn_Send.UseVisualStyleBackColor = false;
            this.btn_Send.Click += new System.EventHandler(this.Btn_Send_Click);
            // 
            // pn_infor
            // 
            this.pn_infor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_infor.Controls.Add(this.label2);
            this.pn_infor.Controls.Add(this.txt_PlayerName);
            this.pn_infor.Controls.Add(this.pgb_CountDown);
            this.pn_infor.Controls.Add(this.pb_Avatar);
            this.pn_infor.Controls.Add(this.txt_IP);
            this.pn_infor.Controls.Add(this.label1);
            this.pn_infor.Controls.Add(this.logo);
            this.pn_infor.Location = new System.Drawing.Point(773, 39);
            this.pn_infor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_infor.Name = "pn_infor";
            this.pn_infor.Size = new System.Drawing.Size(313, 220);
            this.pn_infor.TabIndex = 32;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(13, 97);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(353, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "---------------------------------------------------------------------";
            // 
            // txt_PlayerName
            // 
            this.txt_PlayerName.Location = new System.Drawing.Point(145, 132);
            this.txt_PlayerName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_PlayerName.Name = "txt_PlayerName";
            this.txt_PlayerName.ReadOnly = true;
            this.txt_PlayerName.Size = new System.Drawing.Size(132, 22);
            this.txt_PlayerName.TabIndex = 7;
            // 
            // pgb_CountDown
            // 
            this.pgb_CountDown.Location = new System.Drawing.Point(145, 164);
            this.pgb_CountDown.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pgb_CountDown.Name = "pgb_CountDown";
            this.pgb_CountDown.Size = new System.Drawing.Size(133, 28);
            this.pgb_CountDown.TabIndex = 6;
            // 
            // pb_Avatar
            // 
            this.pb_Avatar.BackColor = System.Drawing.Color.Transparent;
            this.pb_Avatar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb_Avatar.Location = new System.Drawing.Point(4, 117);
            this.pb_Avatar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pb_Avatar.Name = "pb_Avatar";
            this.pb_Avatar.Size = new System.Drawing.Size(105, 90);
            this.pb_Avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Avatar.TabIndex = 5;
            this.pb_Avatar.TabStop = false;
            // 
            // txt_IP
            // 
            this.txt_IP.Location = new System.Drawing.Point(145, 52);
            this.txt_IP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_IP.Name = "txt_IP";
            this.txt_IP.Size = new System.Drawing.Size(132, 22);
            this.txt_IP.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(139, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nhom 17";
            // 
            // logo
            // 
            this.logo.BackColor = System.Drawing.Color.Transparent;
            this.logo.BackgroundImage = global::GameCaro.Properties.Resources.Download_free_vector_of_Clean_medical_patterned_background_vector_by_marinemynt_about_medicine__health__pharmacy__medical_background__and_pharmacy_background_2292666;
            this.logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logo.Location = new System.Drawing.Point(4, 4);
            this.logo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(105, 94);
            this.logo.TabIndex = 0;
            this.logo.TabStop = false;
            // 
            // txt_Chat
            // 
            this.txt_Chat.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_Chat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Chat.Location = new System.Drawing.Point(773, 334);
            this.txt_Chat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Chat.Name = "txt_Chat";
            this.txt_Chat.ReadOnly = true;
            this.txt_Chat.Size = new System.Drawing.Size(312, 221);
            this.txt_Chat.TabIndex = 33;
            this.txt_Chat.Text = "";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(162, 6);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.NewGameToolStripMenuItem_Click);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(60, 26);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // pn_GameBoard
            // 
            this.pn_GameBoard.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pn_GameBoard.Location = new System.Drawing.Point(12, 39);
            this.pn_GameBoard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pn_GameBoard.Name = "pn_GameBoard";
            this.pn_GameBoard.Size = new System.Drawing.Size(738, 562);
            this.pn_GameBoard.TabIndex = 30;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 609);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1103, 30);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_Back
            // 
            this.btn_Back.BackColor = System.Drawing.Color.Transparent;
            this.btn_Back.BackgroundImage = global::GameCaro.Properties.Resources.Undo_Main;
            this.btn_Back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Back.Location = new System.Drawing.Point(0, 0);
            this.btn_Back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Back.Name = "btn_Back";
            this.btn_Back.Size = new System.Drawing.Size(51, 33);
            this.btn_Back.TabIndex = 43;
            this.btn_Back.UseVisualStyleBackColor = false;
            this.btn_Back.Click += new System.EventHandler(this.QuitToolStripMenuItem_Click);
            // 
            // btn_LAN
            // 
            this.btn_LAN.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_LAN.BackgroundColor = System.Drawing.Color.LimeGreen;
            this.btn_LAN.BorderColor = System.Drawing.Color.Crimson;
            this.btn_LAN.BorderRadius = 40;
            this.btn_LAN.BorderSize = 1;
            this.btn_LAN.FlatAppearance.BorderSize = 0;
            this.btn_LAN.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LAN.Font = new System.Drawing.Font("Forte", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_LAN.ForeColor = System.Drawing.Color.White;
            this.btn_LAN.Location = new System.Drawing.Point(960, 267);
            this.btn_LAN.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LAN.Name = "btn_LAN";
            this.btn_LAN.Size = new System.Drawing.Size(127, 59);
            this.btn_LAN.TabIndex = 42;
            this.btn_LAN.Text = "Connect";
            this.btn_LAN.TextColor = System.Drawing.Color.White;
            this.btn_LAN.UseVisualStyleBackColor = false;
            this.btn_LAN.Click += new System.EventHandler(this.Btn_LAN_Click);
            // 
            // btn_Redo
            // 
            this.btn_Redo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Redo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Redo.BackgroundImage = global::GameCaro.Properties.Resources.Redo;
            this.btn_Redo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Redo.BorderColor = System.Drawing.Color.Lime;
            this.btn_Redo.BorderRadius = 30;
            this.btn_Redo.BorderSize = 1;
            this.btn_Redo.FlatAppearance.BorderSize = 0;
            this.btn_Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Redo.ForeColor = System.Drawing.Color.White;
            this.btn_Redo.Location = new System.Drawing.Point(867, 267);
            this.btn_Redo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Redo.Name = "btn_Redo";
            this.btn_Redo.Size = new System.Drawing.Size(81, 59);
            this.btn_Redo.TabIndex = 41;
            this.btn_Redo.TextColor = System.Drawing.Color.White;
            this.btn_Redo.UseVisualStyleBackColor = false;
            this.btn_Redo.Click += new System.EventHandler(this.Btn_Redo_Click);
            // 
            // btn_Undo
            // 
            this.btn_Undo.BackColor = System.Drawing.Color.Transparent;
            this.btn_Undo.BackgroundColor = System.Drawing.Color.Transparent;
            this.btn_Undo.BackgroundImage = global::GameCaro.Properties.Resources.Undo;
            this.btn_Undo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Undo.BorderColor = System.Drawing.Color.Lime;
            this.btn_Undo.BorderRadius = 30;
            this.btn_Undo.BorderSize = 1;
            this.btn_Undo.FlatAppearance.BorderSize = 0;
            this.btn_Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Undo.ForeColor = System.Drawing.Color.White;
            this.btn_Undo.Location = new System.Drawing.Point(773, 267);
            this.btn_Undo.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Undo.Name = "btn_Undo";
            this.btn_Undo.Size = new System.Drawing.Size(81, 59);
            this.btn_Undo.TabIndex = 40;
            this.btn_Undo.TextColor = System.Drawing.Color.White;
            this.btn_Undo.UseVisualStyleBackColor = false;
            this.btn_Undo.Click += new System.EventHandler(this.Btn_Undo_Click);
            // 
            // frmLAN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 639);
            this.Controls.Add(this.btn_Back);
            this.Controls.Add(this.btn_LAN);
            this.Controls.Add(this.btn_Redo);
            this.Controls.Add(this.btn_Undo);
            this.Controls.Add(this.txt_Message);
            this.Controls.Add(this.btn_Send);
            this.Controls.Add(this.pn_infor);
            this.Controls.Add(this.txt_Chat);
            this.Controls.Add(this.pn_GameBoard);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLAN";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Game Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameCaro_FormClosing);
            this.Shown += new System.EventHandler(this.GameCaro_Shown);
            this.pn_infor.ResumeLayout(false);
            this.pn_infor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Avatar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox txt_Message;
        private System.Windows.Forms.Timer tm_CountDown;
        private System.Windows.Forms.Button btn_Send;
        private System.Windows.Forms.Panel pn_infor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_PlayerName;
        private System.Windows.Forms.ProgressBar pgb_CountDown;
        private System.Windows.Forms.PictureBox pb_Avatar;
        private System.Windows.Forms.TextBox txt_IP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox logo;
        private System.Windows.Forms.RichTextBox txt_Chat;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pn_GameBoard;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private myButton btn_LAN;
        private myButton btn_Redo;
        private myButton btn_Undo;
        private System.Windows.Forms.Button btn_Back;
    }
}
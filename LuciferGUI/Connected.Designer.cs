namespace LuciferGUI
{
    partial class Connected
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
            this.tb_logcommand = new System.Windows.Forms.RichTextBox();
            this.rc_chat = new System.Windows.Forms.RichTextBox();
            this.lbl_prefix = new MetroFramework.Controls.MetroLabel();
            this.tb_prefix = new MetroFramework.Controls.MetroTextBox();
            this.lbl_server = new MetroFramework.Controls.MetroLabel();
            this.cb_serv = new System.Windows.Forms.ComboBox();
            this.cb_channel = new System.Windows.Forms.ComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lbl_input = new MetroFramework.Controls.MetroLabel();
            this.tb_input = new MetroFramework.Controls.MetroTextBox();
            this.btn_deletechannel = new MetroFramework.Controls.MetroButton();
            this.btn_banall = new MetroFramework.Controls.MetroButton();
            this.lbl_chanmess = new MetroFramework.Controls.MetroButton();
            this.tb_chanmessall = new MetroFramework.Controls.MetroButton();
            this.tb_nbspam = new MetroFramework.Controls.MetroTextBox();
            this.tb_numchan = new MetroFramework.Controls.MetroTextBox();
            this.btn_createchan = new MetroFramework.Controls.MetroButton();
            this.gb_rpc = new System.Windows.Forms.GroupBox();
            this.btn_joua = new MetroFramework.Controls.MetroButton();
            this.tb_joue_lien = new MetroFramework.Controls.MetroTextBox();
            this.lbl_joue_lien = new MetroFramework.Controls.MetroLabel();
            this.btn_joue = new MetroFramework.Controls.MetroTextBox();
            this.lbl_joue = new MetroFramework.Controls.MetroLabel();
            this.lbl_username_title = new System.Windows.Forms.Label();
            this.tb_save_logs = new MetroFramework.Controls.MetroButton();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.lbl_kickall = new MetroFramework.Controls.MetroButton();
            this.btn_allmesspri = new MetroFramework.Controls.MetroButton();
            this.btn_exit = new MetroFramework.Controls.MetroButton();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_nitrogen = new MetroFramework.Controls.MetroButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gb_rpc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_logcommand
            // 
            this.tb_logcommand.BackColor = System.Drawing.Color.Black;
            this.tb_logcommand.ForeColor = System.Drawing.Color.Green;
            this.tb_logcommand.Location = new System.Drawing.Point(452, 292);
            this.tb_logcommand.Name = "tb_logcommand";
            this.tb_logcommand.ReadOnly = true;
            this.tb_logcommand.Size = new System.Drawing.Size(457, 326);
            this.tb_logcommand.TabIndex = 1;
            this.tb_logcommand.Text = "";
            this.tb_logcommand.TextChanged += new System.EventHandler(this.tb_logcommand_TextChanged);
            // 
            // rc_chat
            // 
            this.rc_chat.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rc_chat.ForeColor = System.Drawing.Color.Green;
            this.rc_chat.Location = new System.Drawing.Point(0, 292);
            this.rc_chat.Name = "rc_chat";
            this.rc_chat.ReadOnly = true;
            this.rc_chat.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
            this.rc_chat.Size = new System.Drawing.Size(446, 326);
            this.rc_chat.TabIndex = 2;
            this.rc_chat.Text = "";
            this.rc_chat.TextChanged += new System.EventHandler(this.rc_chat_TextChanged);
            // 
            // lbl_prefix
            // 
            this.lbl_prefix.AutoSize = true;
            this.lbl_prefix.Location = new System.Drawing.Point(23, 72);
            this.lbl_prefix.Name = "lbl_prefix";
            this.lbl_prefix.Size = new System.Drawing.Size(42, 19);
            this.lbl_prefix.TabIndex = 3;
            this.lbl_prefix.Text = "Préfix";
            // 
            // tb_prefix
            // 
            this.tb_prefix.Location = new System.Drawing.Point(71, 72);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(45, 23);
            this.tb_prefix.TabIndex = 4;
            this.tb_prefix.Text = "!";
            this.tb_prefix.TextChanged += new System.EventHandler(this.tb_prefix_TextChanged);
            // 
            // lbl_server
            // 
            this.lbl_server.AutoSize = true;
            this.lbl_server.Location = new System.Drawing.Point(81, 111);
            this.lbl_server.Name = "lbl_server";
            this.lbl_server.Size = new System.Drawing.Size(54, 19);
            this.lbl_server.TabIndex = 5;
            this.lbl_server.Text = "Serveur";
            // 
            // cb_serv
            // 
            this.cb_serv.BackColor = System.Drawing.SystemColors.MenuText;
            this.cb_serv.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_serv.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.cb_serv.FormattingEnabled = true;
            this.cb_serv.Location = new System.Drawing.Point(9, 133);
            this.cb_serv.Name = "cb_serv";
            this.cb_serv.Size = new System.Drawing.Size(213, 21);
            this.cb_serv.TabIndex = 6;
            this.cb_serv.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cb_channel
            // 
            this.cb_channel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_channel.Enabled = false;
            this.cb_channel.FormattingEnabled = true;
            this.cb_channel.Location = new System.Drawing.Point(9, 196);
            this.cb_channel.Name = "cb_channel";
            this.cb_channel.Size = new System.Drawing.Size(213, 21);
            this.cb_channel.TabIndex = 8;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(81, 174);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(56, 19);
            this.metroLabel1.TabIndex = 7;
            this.metroLabel1.Text = "Channel";
            // 
            // lbl_input
            // 
            this.lbl_input.AutoSize = true;
            this.lbl_input.Location = new System.Drawing.Point(164, 72);
            this.lbl_input.Name = "lbl_input";
            this.lbl_input.Size = new System.Drawing.Size(38, 19);
            this.lbl_input.TabIndex = 9;
            this.lbl_input.Text = "Input";
            // 
            // tb_input
            // 
            this.tb_input.Location = new System.Drawing.Point(208, 72);
            this.tb_input.Name = "tb_input";
            this.tb_input.Size = new System.Drawing.Size(543, 23);
            this.tb_input.TabIndex = 10;
            this.tb_input.Text = "Exemple : Message / Texte / Raison de ban";
            // 
            // btn_deletechannel
            // 
            this.btn_deletechannel.Location = new System.Drawing.Point(9, 232);
            this.btn_deletechannel.Name = "btn_deletechannel";
            this.btn_deletechannel.Size = new System.Drawing.Size(213, 23);
            this.btn_deletechannel.TabIndex = 11;
            this.btn_deletechannel.Text = "Supprimer tous les channels du serveur";
            this.btn_deletechannel.Click += new System.EventHandler(this.btn_deletechannel_Click);
            // 
            // btn_banall
            // 
            this.btn_banall.Location = new System.Drawing.Point(9, 261);
            this.btn_banall.Name = "btn_banall";
            this.btn_banall.Size = new System.Drawing.Size(213, 23);
            this.btn_banall.TabIndex = 12;
            this.btn_banall.Text = "Bannir tous les users du serveur";
            this.btn_banall.Click += new System.EventHandler(this.btn_banall_Click);
            // 
            // lbl_chanmess
            // 
            this.lbl_chanmess.Location = new System.Drawing.Point(240, 133);
            this.lbl_chanmess.Name = "lbl_chanmess";
            this.lbl_chanmess.Size = new System.Drawing.Size(206, 23);
            this.lbl_chanmess.TabIndex = 13;
            this.lbl_chanmess.Text = "Envoyer un message sur le channel";
            this.lbl_chanmess.Click += new System.EventHandler(this.lbl_chanmess_Click);
            // 
            // tb_chanmessall
            // 
            this.tb_chanmessall.Location = new System.Drawing.Point(274, 162);
            this.tb_chanmessall.Name = "tb_chanmessall";
            this.tb_chanmessall.Size = new System.Drawing.Size(172, 23);
            this.tb_chanmessall.TabIndex = 15;
            this.tb_chanmessall.Text = "Message sur tous les channels";
            this.tb_chanmessall.Click += new System.EventHandler(this.tb_chanmessall_Click);
            // 
            // tb_nbspam
            // 
            this.tb_nbspam.Location = new System.Drawing.Point(240, 162);
            this.tb_nbspam.Name = "tb_nbspam";
            this.tb_nbspam.Size = new System.Drawing.Size(28, 23);
            this.tb_nbspam.TabIndex = 16;
            this.tb_nbspam.Text = "5";
            // 
            // tb_numchan
            // 
            this.tb_numchan.Location = new System.Drawing.Point(240, 196);
            this.tb_numchan.Name = "tb_numchan";
            this.tb_numchan.Size = new System.Drawing.Size(28, 23);
            this.tb_numchan.TabIndex = 17;
            this.tb_numchan.Text = "5";
            // 
            // btn_createchan
            // 
            this.btn_createchan.Location = new System.Drawing.Point(274, 196);
            this.btn_createchan.Name = "btn_createchan";
            this.btn_createchan.Size = new System.Drawing.Size(172, 23);
            this.btn_createchan.TabIndex = 18;
            this.btn_createchan.Text = "Création de channel(s)";
            this.btn_createchan.Click += new System.EventHandler(this.btn_createchan_Click);
            // 
            // gb_rpc
            // 
            this.gb_rpc.Controls.Add(this.btn_joua);
            this.gb_rpc.Controls.Add(this.tb_joue_lien);
            this.gb_rpc.Controls.Add(this.lbl_joue_lien);
            this.gb_rpc.Controls.Add(this.btn_joue);
            this.gb_rpc.Controls.Add(this.lbl_joue);
            this.gb_rpc.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.gb_rpc.Location = new System.Drawing.Point(452, 111);
            this.gb_rpc.Name = "gb_rpc";
            this.gb_rpc.Size = new System.Drawing.Size(202, 173);
            this.gb_rpc.TabIndex = 20;
            this.gb_rpc.TabStop = false;
            this.gb_rpc.Text = "Configuration joue à :";
            // 
            // btn_joua
            // 
            this.btn_joua.Location = new System.Drawing.Point(69, 144);
            this.btn_joua.Name = "btn_joua";
            this.btn_joua.Size = new System.Drawing.Size(75, 23);
            this.btn_joua.TabIndex = 25;
            this.btn_joua.Text = "Accepter";
            this.btn_joua.Click += new System.EventHandler(this.btn_joua_Click);
            // 
            // tb_joue_lien
            // 
            this.tb_joue_lien.Location = new System.Drawing.Point(6, 95);
            this.tb_joue_lien.Name = "tb_joue_lien";
            this.tb_joue_lien.Size = new System.Drawing.Size(190, 23);
            this.tb_joue_lien.TabIndex = 24;
            // 
            // lbl_joue_lien
            // 
            this.lbl_joue_lien.AutoSize = true;
            this.lbl_joue_lien.Location = new System.Drawing.Point(59, 73);
            this.lbl_joue_lien.Name = "lbl_joue_lien";
            this.lbl_joue_lien.Size = new System.Drawing.Size(71, 19);
            this.lbl_joue_lien.TabIndex = 23;
            this.lbl_joue_lien.Text = "Lien Twitch";
            // 
            // btn_joue
            // 
            this.btn_joue.Location = new System.Drawing.Point(6, 38);
            this.btn_joue.Name = "btn_joue";
            this.btn_joue.Size = new System.Drawing.Size(190, 23);
            this.btn_joue.TabIndex = 22;
            // 
            // lbl_joue
            // 
            this.lbl_joue.AutoSize = true;
            this.lbl_joue.Location = new System.Drawing.Point(69, 16);
            this.lbl_joue.Name = "lbl_joue";
            this.lbl_joue.Size = new System.Drawing.Size(51, 19);
            this.lbl_joue.TabIndex = 21;
            this.lbl_joue.Text = "Joue à ";
            // 
            // lbl_username_title
            // 
            this.lbl_username_title.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_username_title.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.lbl_username_title.Location = new System.Drawing.Point(660, 204);
            this.lbl_username_title.Name = "lbl_username_title";
            this.lbl_username_title.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbl_username_title.Size = new System.Drawing.Size(249, 13);
            this.lbl_username_title.TabIndex = 22;
            this.lbl_username_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
    
            // 
            // tb_save_logs
            // 
            this.tb_save_logs.Location = new System.Drawing.Point(676, 261);
            this.tb_save_logs.Name = "tb_save_logs";
            this.tb_save_logs.Size = new System.Drawing.Size(209, 23);
            this.tb_save_logs.TabIndex = 24;
            this.tb_save_logs.Text = "Enregistrer les logs de conversations";
            this.tb_save_logs.Click += new System.EventHandler(this.tb_save_logs_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // lbl_kickall
            // 
            this.lbl_kickall.Location = new System.Drawing.Point(240, 261);
            this.lbl_kickall.Name = "lbl_kickall";
            this.lbl_kickall.Size = new System.Drawing.Size(206, 23);
            this.lbl_kickall.TabIndex = 14;
            this.lbl_kickall.Text = "Invite bypass sur tous les channels";
            this.lbl_kickall.Click += new System.EventHandler(this.lbl_kickall_Click);
            // 
            // btn_allmesspri
            // 
            this.btn_allmesspri.Location = new System.Drawing.Point(240, 232);
            this.btn_allmesspri.Name = "btn_allmesspri";
            this.btn_allmesspri.Size = new System.Drawing.Size(206, 23);
            this.btn_allmesspri.TabIndex = 25;
            this.btn_allmesspri.Text = "Envoyer un message à tous les users";
            this.btn_allmesspri.Click += new System.EventHandler(this.btn_allmesspri_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(768, 72);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(103, 23);
            this.btn_exit.TabIndex = 26;
            this.btn_exit.Text = "Se déconnecter";
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(743, 101);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(92, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 27;
            this.pictureBox1.TabStop = false;

            // 
            // btn_nitrogen
            // 
            this.btn_nitrogen.Location = new System.Drawing.Point(676, 232);
            this.btn_nitrogen.Name = "btn_nitrogen";
            this.btn_nitrogen.Size = new System.Drawing.Size(209, 23);
            this.btn_nitrogen.TabIndex = 28;
            this.btn_nitrogen.Text = "Génération de Discord Nitro  [NEW]";
            this.btn_nitrogen.Click += new System.EventHandler(this.Btn_nitrogen_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // Connected
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::LuciferGUI.Properties.Resources.discord_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(908, 618);
            this.Controls.Add(this.btn_nitrogen);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_allmesspri);
            this.Controls.Add(this.tb_save_logs);
            this.Controls.Add(this.lbl_username_title);
            this.Controls.Add(this.gb_rpc);
            this.Controls.Add(this.btn_createchan);
            this.Controls.Add(this.tb_numchan);
            this.Controls.Add(this.tb_nbspam);
            this.Controls.Add(this.tb_chanmessall);
            this.Controls.Add(this.lbl_kickall);
            this.Controls.Add(this.lbl_chanmess);
            this.Controls.Add(this.btn_banall);
            this.Controls.Add(this.btn_deletechannel);
            this.Controls.Add(this.tb_input);
            this.Controls.Add(this.lbl_input);
            this.Controls.Add(this.cb_channel);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.cb_serv);
            this.Controls.Add(this.lbl_server);
            this.Controls.Add(this.tb_prefix);
            this.Controls.Add(this.lbl_prefix);
            this.Controls.Add(this.rc_chat);
            this.Controls.Add(this.tb_logcommand);
            this.MaximizeBox = false;
            this.Name = "Connected";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Lucifer-GUI 1.3 CLOSED BETA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Connected_FormClosed);
            this.Load += new System.EventHandler(this.Connected_Load);
            this.gb_rpc.ResumeLayout(false);
            this.gb_rpc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.RichTextBox rc_chat;
        private MetroFramework.Controls.MetroLabel lbl_prefix;
        private MetroFramework.Controls.MetroLabel lbl_server;
        private System.Windows.Forms.ComboBox cb_serv;
        private System.Windows.Forms.ComboBox cb_channel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel lbl_input;
        private MetroFramework.Controls.MetroTextBox tb_input;
        private MetroFramework.Controls.MetroButton btn_deletechannel;
        private MetroFramework.Controls.MetroButton btn_banall;
        private MetroFramework.Controls.MetroButton lbl_chanmess;
        private MetroFramework.Controls.MetroButton tb_chanmessall;
        private MetroFramework.Controls.MetroTextBox tb_nbspam;
        private MetroFramework.Controls.MetroTextBox tb_numchan;
        private MetroFramework.Controls.MetroButton btn_createchan;
        private System.Windows.Forms.GroupBox gb_rpc;
        private MetroFramework.Controls.MetroLabel lbl_joue;
        private MetroFramework.Controls.MetroTextBox btn_joue;
        private MetroFramework.Controls.MetroLabel lbl_joue_lien;
        private MetroFramework.Controls.MetroButton btn_joua;
        private MetroFramework.Controls.MetroTextBox tb_joue_lien;
        private System.Windows.Forms.Label lbl_username_title;
        private MetroFramework.Controls.MetroButton tb_save_logs;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private MetroFramework.Controls.MetroButton lbl_kickall;
        private MetroFramework.Controls.MetroButton btn_allmesspri;
        private MetroFramework.Controls.MetroButton btn_exit;
        private MetroFramework.Components.MetroStyleManager metroStyleManager1;
        public System.Windows.Forms.RichTextBox tb_logcommand;
        public MetroFramework.Controls.MetroTextBox tb_prefix;
        private System.Windows.Forms.PictureBox pictureBox1;
        public MetroFramework.Controls.MetroButton btn_nitrogen;
        private System.Windows.Forms.Timer timer1;
    }
}
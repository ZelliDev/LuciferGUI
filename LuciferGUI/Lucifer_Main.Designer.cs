namespace LuciferGUI
{
    partial class Lucifer_Main
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
            this.lbl_tokens = new MetroFramework.Controls.MetroLabel();
            this.tb_token = new MetroFramework.Controls.MetroTextBox();
            this.cb_config = new MetroFramework.Controls.MetroCheckBox();
            this.tb_projectname = new MetroFramework.Controls.MetroTextBox();
            this.lbl_projectname = new MetroFramework.Controls.MetroLabel();
            this.lbl_config = new System.Windows.Forms.Label();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_about = new System.Windows.Forms.Label();
            this.lbl_exit = new System.Windows.Forms.Label();
            this.lbl_version = new System.Windows.Forms.Label();
            this.cb_typebot = new MetroFramework.Controls.MetroCheckBox();
            this.cb_typesb = new MetroFramework.Controls.MetroCheckBox();
            this.metroStyleManager1 = new MetroFramework.Components.MetroStyleManager(this.components);
            this.tb_accept_terms = new MetroFramework.Controls.MetroCheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pb_connect = new System.Windows.Forms.PictureBox();
            this.pb_logo = new System.Windows.Forms.PictureBox();
            this.pb_menu = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_connect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_tokens
            // 
            this.lbl_tokens.AutoSize = true;
            this.lbl_tokens.Location = new System.Drawing.Point(203, 125);
            this.lbl_tokens.Name = "lbl_tokens";
            this.lbl_tokens.Size = new System.Drawing.Size(112, 19);
            this.lbl_tokens.TabIndex = 1;
            this.lbl_tokens.Text = "Token Bot/Selfbot";
            // 
            // tb_token
            // 
            this.tb_token.Location = new System.Drawing.Point(316, 121);
            this.tb_token.Name = "tb_token";
            this.tb_token.Size = new System.Drawing.Size(347, 23);
            this.tb_token.TabIndex = 2;
            this.tb_token.Click += new System.EventHandler(this.tb_token_Click);
            // 
            // cb_config
            // 
            this.cb_config.AutoSize = true;
            this.cb_config.Enabled = false;
            this.cb_config.Location = new System.Drawing.Point(316, 150);
            this.cb_config.Name = "cb_config";
            this.cb_config.Size = new System.Drawing.Size(218, 15);
            this.cb_config.TabIndex = 5;
            this.cb_config.Text = "Enregistrer le fichier de configuration";
            this.cb_config.UseVisualStyleBackColor = true;
            // 
            // tb_projectname
            // 
            this.tb_projectname.Location = new System.Drawing.Point(316, 190);
            this.tb_projectname.Name = "tb_projectname";
            this.tb_projectname.Size = new System.Drawing.Size(218, 23);
            this.tb_projectname.TabIndex = 6;
            // 
            // lbl_projectname
            // 
            this.lbl_projectname.AutoSize = true;
            this.lbl_projectname.Location = new System.Drawing.Point(203, 190);
            this.lbl_projectname.Name = "lbl_projectname";
            this.lbl_projectname.Size = new System.Drawing.Size(97, 19);
            this.lbl_projectname.TabIndex = 7;
            this.lbl_projectname.Text = "Nom du projet";
            // 
            // lbl_config
            // 
            this.lbl_config.AutoSize = true;
            this.lbl_config.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_config.Location = new System.Drawing.Point(357, 60);
            this.lbl_config.Name = "lbl_config";
            this.lbl_config.Size = new System.Drawing.Size(117, 20);
            this.lbl_config.TabIndex = 9;
            this.lbl_config.Text = "Configuration";
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.Color.Maroon;
            this.lbl_title.Location = new System.Drawing.Point(37, 182);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(113, 25);
            this.lbl_title.TabIndex = 14;
            this.lbl_title.Text = "Lucifer-GUI";
            // 
            // lbl_about
            // 
            this.lbl_about.AutoSize = true;
            this.lbl_about.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_about.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_about.Location = new System.Drawing.Point(52, 276);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(63, 16);
            this.lbl_about.TabIndex = 15;
            this.lbl_about.Text = "À propos";
            this.lbl_about.Click += new System.EventHandler(this.lbl_about_Click);
            // 
            // lbl_exit
            // 
            this.lbl_exit.AutoSize = true;
            this.lbl_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_exit.Location = new System.Drawing.Point(57, 358);
            this.lbl_exit.Name = "lbl_exit";
            this.lbl_exit.Size = new System.Drawing.Size(46, 16);
            this.lbl_exit.TabIndex = 16;
            this.lbl_exit.Text = "Quitter";
            this.lbl_exit.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_version
            // 
            this.lbl_version.AutoSize = true;
            this.lbl_version.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_version.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_version.Location = new System.Drawing.Point(55, 316);
            this.lbl_version.Name = "lbl_version";
            this.lbl_version.Size = new System.Drawing.Size(54, 16);
            this.lbl_version.TabIndex = 17;
            this.lbl_version.Text = "Version";
            this.lbl_version.Click += new System.EventHandler(this.lbl_version_Click);
            // 
            // cb_typebot
            // 
            this.cb_typebot.AutoSize = true;
            this.cb_typebot.Location = new System.Drawing.Point(306, 236);
            this.cb_typebot.Name = "cb_typebot";
            this.cb_typebot.Size = new System.Drawing.Size(75, 15);
            this.cb_typebot.TabIndex = 18;
            this.cb_typebot.Text = "Token Bot";
            this.cb_typebot.UseVisualStyleBackColor = true;
            // 
            // cb_typesb
            // 
            this.cb_typesb.AutoSize = true;
            this.cb_typesb.Location = new System.Drawing.Point(432, 236);
            this.cb_typesb.Name = "cb_typesb";
            this.cb_typesb.Size = new System.Drawing.Size(94, 15);
            this.cb_typesb.TabIndex = 19;
            this.cb_typesb.Text = "Token Selfbot";
            this.cb_typesb.UseVisualStyleBackColor = true;
            // 
            // metroStyleManager1
            // 
            this.metroStyleManager1.Owner = this;
            this.metroStyleManager1.Style = MetroFramework.MetroColorStyle.Black;
            this.metroStyleManager1.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // tb_accept_terms
            // 
            this.tb_accept_terms.AutoSize = true;
            this.tb_accept_terms.Location = new System.Drawing.Point(261, 302);
            this.tb_accept_terms.Name = "tb_accept_terms";
            this.tb_accept_terms.Size = new System.Drawing.Size(373, 30);
            this.tb_accept_terms.TabIndex = 20;
            this.tb_accept_terms.Text = "Je suis responsable de mon compte et je suis conscient des risques\r\nde sanctions " +
    "sur Discord. ";
            this.tb_accept_terms.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Image = global::LuciferGUI.Properties.Resources.pour_zelly;
            this.pictureBox1.Location = new System.Drawing.Point(186, 423);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 70);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_connect
            // 
            this.pb_connect.Image = global::LuciferGUI.Properties.Resources.bouton_connexion;
            this.pb_connect.Location = new System.Drawing.Point(347, 358);
            this.pb_connect.Name = "pb_connect";
            this.pb_connect.Size = new System.Drawing.Size(162, 44);
            this.pb_connect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_connect.TabIndex = 12;
            this.pb_connect.TabStop = false;
            this.pb_connect.Click += new System.EventHandler(this.pb_connect_Click);
            // 
            // pb_logo
            // 
            this.pb_logo.Image = global::LuciferGUI.Properties.Resources._167758;
            this.pb_logo.Location = new System.Drawing.Point(41, 46);
            this.pb_logo.Name = "pb_logo";
            this.pb_logo.Size = new System.Drawing.Size(146, 133);
            this.pb_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logo.TabIndex = 4;
            this.pb_logo.TabStop = false;
            this.pb_logo.Click += new System.EventHandler(this.pb_logo_Click);
            // 
            // pb_menu
            // 
            this.pb_menu.Image = global::LuciferGUI.Properties.Resources.d_back;
            this.pb_menu.Location = new System.Drawing.Point(0, 63);
            this.pb_menu.Name = "pb_menu";
            this.pb_menu.Size = new System.Drawing.Size(187, 430);
            this.pb_menu.TabIndex = 3;
            this.pb_menu.TabStop = false;
            // 
            // Lucifer_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 492);
            this.Controls.Add(this.tb_accept_terms);
            this.Controls.Add(this.cb_typesb);
            this.Controls.Add(this.cb_typebot);
            this.Controls.Add(this.lbl_version);
            this.Controls.Add(this.lbl_exit);
            this.Controls.Add(this.lbl_about);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_connect);
            this.Controls.Add(this.lbl_config);
            this.Controls.Add(this.lbl_projectname);
            this.Controls.Add(this.tb_projectname);
            this.Controls.Add(this.cb_config);
            this.Controls.Add(this.pb_logo);
            this.Controls.Add(this.pb_menu);
            this.Controls.Add(this.tb_token);
            this.Controls.Add(this.lbl_tokens);
            this.MaximizeBox = false;
            this.Name = "Lucifer_Main";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Black;
            this.Text = "Lucifer-GUI CLOSED BETA 1.3";
            this.Load += new System.EventHandler(this.Lucifer_Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_connect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_menu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private MetroFramework.Controls.MetroLabel lbl_tokens;
        private MetroFramework.Controls.MetroTextBox tb_token;
        private System.Windows.Forms.PictureBox pb_menu;
        private System.Windows.Forms.PictureBox pb_logo;
        private MetroFramework.Controls.MetroCheckBox cb_config;
        private MetroFramework.Controls.MetroTextBox tb_projectname;
        private MetroFramework.Controls.MetroLabel lbl_projectname;
        private System.Windows.Forms.Label lbl_config;
        private System.Windows.Forms.PictureBox pb_connect;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_about;
        private System.Windows.Forms.Label lbl_exit;
        private System.Windows.Forms.Label lbl_version;
        private MetroFramework.Controls.MetroCheckBox cb_typebot;
        private MetroFramework.Controls.MetroCheckBox cb_typesb;
        public MetroFramework.Components.MetroStyleManager metroStyleManager1;
        private MetroFramework.Controls.MetroCheckBox tb_accept_terms;
    }
}
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using Newtonsoft.Json;
using DiscordRPC;
using DiscordRPC.Logging;

namespace LuciferGUI
{
    public partial class Lucifer_Main : MetroFramework.Forms.MetroForm
    {
       // public DiscordRPC.DiscordRpcClient client;
        public Lucifer_Main()
        {
            InitializeComponent();
            Styling();
            this.StyleManager = metroStyleManager1;
            metroStyleManager1.Theme = MetroThemeStyle.Dark;
            //client = new DiscordRPC.DiscordRpcClient("584200653203832853");
            //teste();
        }

        // public DiscordRPC.DiscordRpcClient client;

        public static DiscordRPC.DiscordRpcClient client;


        public void Lucifer_Main_Load(object sender, EventArgs e)
        {
            Initialize();
            pb_logo.Parent = pb_menu;
            pb_logo.BackColor = Color.Transparent;

        }
        void Initialize()
        {
         
            client = new DiscordRpcClient("584200653203832853");

            //Set the logger
            client.Logger = new ConsoleLogger() { Level = LogLevel.Warning };

            //Subscribe to events
            client.OnReady += (sender, e) =>
            {
                Console.WriteLine("Received Ready from user {0}", e.User.Username);
            };

            client.OnPresenceUpdate += (sender, e) =>
            {
                Console.WriteLine("Received Update! {0}", e.Presence);
            };


            client.Initialize();

           
            client.SetPresence(new RichPresence()
            {
                Details = "Dans le menu de connexion",
                State = "Closed Beta 1.3",
                Assets = new Assets()
                {
                    LargeImageKey = "demon2",
                    LargeImageText = "Created by Zelly⛧#6666",
                    SmallImageKey = "none"
                }
            });
        }



        public void Styling()
        {
           
           
            cb_typebot.Style = MetroColorStyle.Silver;
            cb_config.Style = MetroColorStyle.Silver;
            tb_accept_terms.Style = MetroColorStyle.Silver;
            cb_typesb.Style = MetroColorStyle.Silver;
         
            pb_logo.BackColor = Color.FromArgb(114, 137, 218);
     
            
            this.BackColor = Color.Black;
            lbl_config.ForeColor = Color.FromArgb(114, 137, 218);
            lbl_title.BackColor = Color.FromArgb(114, 137, 218);
            lbl_about.BackColor = Color.FromArgb(114, 137, 218);
            lbl_exit.BackColor = Color.FromArgb(114, 137, 218);
            lbl_version.BackColor = Color.FromArgb(114, 137, 218);
            lbl_title.BackColor = Color.Transparent;
            lbl_title.Parent = pb_menu;
            lbl_version.BackColor = Color.Transparent;
            lbl_version.Parent = pb_menu;
            lbl_about.BackColor = Color.Transparent;
            lbl_about.Parent = pb_menu;
            lbl_exit.BackColor = Color.Transparent;
            lbl_exit.Parent = pb_menu;
        }


        private void pb_logo_Click(object sender, EventArgs e)
        {

        }

        public void pb_connect_Click(object sender, EventArgs e)
        {
            if (tb_token.Text == "")
            {
                MessageBox.Show("Vous devez mettre votre token", "ERREUR TOKEN", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (tb_accept_terms.Checked == false)
                {
                    
                }
                else
                {
                    Connected.title = tb_projectname.Text;
                    Connected.token = tb_token.Text;
                    Connected connected = new Connected();


                    if (cb_typebot.Checked == true && cb_typesb.Checked == false)
                    {
                        Connected.BotType = "Bot";
                    }
                    if (cb_typebot.Checked == false && cb_typesb.Checked == true)
                    {
                        Connected.BotType = "Selfbot";
                    }

                    if (tb_projectname.Text == "" || tb_projectname.Text != "")
                    {
                        client.Dispose();
                        this.Hide();
                        connected.Show();
                    }
                }
               
                
             
            }
           
            
            
        }

        private void lbl_about_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lucifer a été conçu afin de faciliter l'utilisation d'un selfbot. Notre engine contient des commandes de tout genre." + Environment.NewLine+
                "À savoir sur notre logiciel : "+ Environment.NewLine+
                "1) Aucun token est enregistré"+Environment.NewLine+
                "2) Le logiciel log seulement le pseudonyme de votre bot, son ID et ses heures de connexions" + Environment.NewLine+
                "3) Nous pouvons nous permettre de révoquer à tout moment l'accès de quelqu'un sur notre application" + Environment.NewLine+
                "4) Nous ne sommes pas responsable de votre utilisation sur la plateforme" + Environment.NewLine+
                "5) Ce logiciel a été créé par 「Ξ」Zelly⛧#6666, ajoutez moi :)" + Environment.NewLine+
                "Version 1.3.0.0 CLOSED BETA","À PROPOS DE LUCIFER-GUI", MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lbl_version_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Lucifer-GUI version 1.3 CLOSED BETA", "Version", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/KEjBy4d");
        }

        private void tb_token_Click(object sender, EventArgs e)
        {
            //teste();
        }

        private void Cb_net_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

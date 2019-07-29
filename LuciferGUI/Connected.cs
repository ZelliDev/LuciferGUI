using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Discord;
using Discord.Commands;
using Discord.Rpc;
using Discord.WebSocket;
using DiscordRPC;
using DiscordRPC.Logging;
using MetroFramework;
using Microsoft.Extensions.DependencyInjection;

namespace LuciferGUI
{
    public partial class Connected : MetroFramework.Forms.MetroForm
    {
        
        public Connected()
        {
            InitializeComponent();

        }
        public static string title = string.Empty;
        public static string prefix = string.Empty;
        public static string token = string.Empty;
        public static string projectname = string.Empty;
        public static List<string> MuteList = new List<string>();
        public static string BotType = string.Empty;
        public static bool NitroFormOpened = false;
        public static bool SelfBotLocked = true;
      

        public void Connected_Load(object sender, EventArgs e)
        {
            timer1.Start();
            Init_discordrpc();
           // this.TopMost = true;
            prefix = tb_prefix.Text;
            this.Text = "LuciferGUI [1.3] "+ title;
            this.Shown += shown;
           // Initialize();
        }

        private void shown(object sender, EventArgs e)
        {
            starting();
            
        }

        public async void starting()
        {
            try
            {
                SetText("Démarrage des modules de LuciferGUI");
                await Runbot();
            }
            catch (Exception)
            {

                MessageBox.Show("Ceci n'est pas le bon type de token par conséquent le logiciel redémarre", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Restart();
            }

        }
        private DiscordSocketClient _client;
        private CommandService _commandes;
        private IServiceProvider _services;



        public async Task Runbot()
        {
            _client = new DiscordSocketClient();
            _commandes = new CommandService();
            _services = new ServiceCollection()
            .AddSingleton(_client)
            .AddSingleton(_commandes)
            .BuildServiceProvider();
            var tok = Discord.TokenType.Bot;
            if (BotType == "Bot")
            {
                tok = Discord.TokenType.Bot;
            }
            if (BotType == "Selfbot")
            {
                tok = Discord.TokenType.User;
            }
            //_client.Log += logging;
            // _client.Ready += rdy;

            await Chargement_Commandes();


            await _client.LoginAsync(tok, token);
            token = null;

            await _client.StartAsync();
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[Connecting]: Connexion en cours");
            await Task.Delay(-1);
        }
        public async Task Chargement_Commandes()
        {
            _client.MessageReceived += HandleCommandAsync;
            _client.JoinedGuild += RefreshServer;
            _client.LeftGuild += LeftGuild;
            _client.UserJoined += UserJoined;
            _client.MessageDeleted += DeletedMessage;
            _client.UserLeft += UserLeft;
            _client.UserBanned += UserBanned;
            _client.UserUnbanned += UserUnbanned;
            _client.Ready += ready;

            await _commandes.AddModulesAsync(Assembly.GetEntryAssembly());

        }

        private async Task UserUnbanned(SocketUser arg1, SocketGuild arg2)
        {
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[EVENT:UserBanned] : L'utilisateur : " + arg1.Username + "#" + arg1.Discriminator.ToString() + " / ID:" + arg1.Id.ToString() + "/ A été débanni du serveur " + arg2.Name + " /ID:" + arg2.Id.ToString());
        }

        private async Task UserBanned(SocketUser arg1, SocketGuild arg2)
        {
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[EVENT:UserBanned] : L'utilisateur : "+ arg1.Username+"#"+arg1.Discriminator.ToString()+" / ID:"+arg1.Id.ToString()+"/ A été banni du serveur "+arg2.Name + " /ID:"+arg2.Id.ToString());
        }

        private async Task DeletedMessage(Cacheable<IMessage, ulong> arg1, ISocketMessageChannel arg2)
        {
            Discord.IMessage mess = arg2 as IMessage;
            
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[EVENT:MessageDeleted] : Le message "+ arg1.Id.ToString() + " par " + mess.Author.Username+"#"+mess.Author.Discriminator.ToString());
        }

        private async Task LeftGuild(SocketGuild arg)
        {
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[EVENT:LeftServer] : Vous avez quitté le serveur "+ arg.Name.ToString() + " / "+ arg.Id.ToString());

        }

        private async Task UserLeft(SocketGuildUser arg)
        {
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[EVENT:UserLeft] : " + arg.Username.ToString() + "#" + arg.Discriminator.ToString() + " a quitté le serveur " + arg.Guild.Name + " / " + arg.Guild.Id.ToString());
        }

        private async Task UserJoined(SocketGuildUser arg)
        {
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[EVENT:UserJoined] : "+arg.Username.ToString()+"#"+arg.Discriminator.ToString() + " a rejoin le serveur " + arg.Guild.Name + " / "+arg.Guild.Id.ToString());
        }

        private async Task RefreshServer(SocketGuild arg)
        {
            cb_serv.Items.Add(arg.Name + @"\"+arg.Id.ToString());
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[EVENT:JoinedServer] : Vous avez rejoin le serveur "+ arg.Name.ToString() + " / "+ arg.Id.ToString());

        }

        private async Task ready()
        {
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[Ready] : Connecté");

            Additem();
            //this.Text = "LUCIFER-GUI 1.0 ["+_client.CurrentUser.Username+"#"+_client.CurrentUser.Discriminator.ToString()+"]"+"("+_client.CurrentUser.Id.ToString()+"]";
            Add_UserInfo();
            SetText(DateTime.Now.ToString("h:mm:ss tt") + "[Ready] : Connecté");
            await LoadedUserItem();
            SetUsernametitle(_client.CurrentUser.Username.ToString() + "#" + _client.CurrentUser.Discriminator.ToString());
            
           
        }
        void Init_discordrpc()
        {
            DiscordRPC.DiscordRpcClient client;
            client = new DiscordRPC.DiscordRpcClient("584200653203832853");

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
                Details = "Fight Evil With Evil",
                State = "Closed Beta 1.3 by Zelly",
                Assets = new Assets()
                {
                    LargeImageKey = "demon2",
                    LargeImageText = "By Zelly",
                    SmallImageKey = ""
                }
            });
        }


        public async Task LoadedUserItem()
        {
            pictureBox1.Load(_client.CurrentUser.GetAvatarUrl().ToString());
            SetUsernametitle(_client.CurrentUser.Username.ToString() + "#" + _client.CurrentUser.Discriminator.ToString());
            this.Text = "LuciferGUI[1.3] [" + _client.CurrentUser.Username + "#" + _client.CurrentUser.Discriminator.ToString() + "]";

        }

        public void Additem()
        {
            

            foreach (var item in _client.Guilds)
            {
                
                Populator(item.Name.ToString()+@"\"+item.Id.ToString());
                
            }
           

        }

        public void Add_UserInfo()
        {

            SetUserInfo(" USER : "+ _client.CurrentUser.Username+"#"+_client.CurrentUser.Discriminator.ToString() + Environment.NewLine+ 
                " ID : "+ _client.CurrentUser.Id.ToString() + Environment.NewLine+
                " Date de création : "+ _client.CurrentUser.CreatedAt.ToString() + Environment.NewLine+
                " PING : "+ _client.Latency.ToString() + " MS"+ Environment.NewLine);
        }


        public async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;

            if (message == null || message.Author.IsBot) return;

            

            int argPos = 0;
            var context = new SocketCommandContext(_client, message);
            string resultat = GetMutedUser(context.Message.Author.Id.ToString());
           
            if (resultat == "muted")
            {
                await context.Message.DeleteAsync();
                
            }
            else
            {
                if (message.HasStringPrefix(tb_prefix.Text, ref argPos))
                {

                    if (BotType == "Bot")
                    {
                        var result = await _commandes.ExecuteAsync(context, argPos, _services);
                        if (!result.IsSuccess)
                        {
                            SetText(" " + DateTime.Now.ToString("h:mm:ss tt") + "[ERROR]" + message.Author.Username + "#" + message.Author.Discriminator.ToString() + " a tapé : " + Environment.NewLine +
                       message.Content.ToString() + " / ERROR : " + result.Error.ToString());
                        }
                    }
                    if (BotType == "Selfbot")
                    {
                        if (SelfBotLocked == true)
                        {
                            if (context.Message.Author.Id.ToString() == context.Client.CurrentUser.Id.ToString())
                            {
                                var result = await _commandes.ExecuteAsync(context, argPos, _services);

                                if (!result.IsSuccess)
                                {

                                    SetText(" " + DateTime.Now.ToString("h:mm:ss tt") + "[ERROR]" + message.Author.Username + "#" + message.Author.Discriminator.ToString() + " a tapé : " + Environment.NewLine +
                               message.Content.ToString() + " / ERROR : " + result.Error.ToString());
                                }
                            }
                        }
                        if (SelfBotLocked == false)
                        {
                            var result = await _commandes.ExecuteAsync(context, argPos, _services);

                            if (!result.IsSuccess)
                            {

                                SetText(" " + DateTime.Now.ToString("h:mm:ss tt") + "[ERROR]" + message.Author.Username + "#" + message.Author.Discriminator.ToString() + " a tapé : " + Environment.NewLine +
                           message.Content.ToString() + " / ERROR : " + result.Error.ToString());
                            }
                        }
                       
                    }
                }
                else
                {

                    //Picturing("demon2.png");
                    //SetPic("demon2.png");
                    SetTextchat(" " + DateTime.Now.ToString("h:mm:ss tt") + "[MESSAGE] " + arg.Author.Username + "#" + arg.Author.Discriminator.ToString() + "/ID:" + arg.Author.Id.ToString() + "/GUILD : " + context.Guild.Name.ToString() + " / Channel : " + arg.Channel.Name + "(" + arg.Channel.Id.ToString() + ") : " + arg.Content.ToString() + Environment.NewLine);
                }

            }

        }

        public static string GetMutedUser(string id)
        {
            string result = "notmuted";
            foreach (var item in MuteList)
            {
                if (item.ToString() == id)
                {
                    result = "muted";
                    return result;
                }
               
                
            }
            return result;
        }
       
        public async Task logging(LogMessage arg)
        {
            
              // var test = MessageBox.Show(arg.Message.ToString());

            SetText(" "+DateTime.Now.ToString("h:mm:ss")+"[LOG]"+arg.Message.ToString());
          
        }




        delegate void SetTextCallBack(string s);


        public void SetUserInfo(string txt)
        {
            if (this.InvokeRequired)
            {
                SetTextCallBack txtCall = new SetTextCallBack(SetUserInfo);
                this.Invoke(txtCall, txt);
            }
            else
            {
                // HERE
                tb_logcommand.Text += " "+ txt;
            }
        }

        public void SetUsernametitle(string txt)
        {
            if (this.InvokeRequired)
            {
                SetTextCallBack txtCall = new SetTextCallBack(SetUsernametitle);
                this.Invoke(txtCall, txt);
            }
            else
            {
                // HERE
                lbl_username_title.Text = _client.CurrentUser.Username.ToString()+ "#"+ _client.CurrentUser.Discriminator.ToString();
            }
        }
      
        public void SetText(string txt)
        {
            if (this.InvokeRequired)
            {
                SetTextCallBack txtCall = new SetTextCallBack(SetText);
                this.Invoke(txtCall, txt);
            }
            else
            {
                
                tb_logcommand.Text += " "+ txt + Environment.NewLine;
                
            }
        }

        

        public void TitleSetup(string txt)
        {
            if (this.InvokeRequired)
            {
                SetTextCallBack txtCall = new SetTextCallBack(TitleSetup);
                this.Invoke(txtCall, txt);
            }
            else
            {
                this.Text = txt;
            }
        }

        public void SetTextchat(string txt)
        {
            if (this.InvokeRequired)
            {
                SetTextCallBack txtCall = new SetTextCallBack(SetTextchat);
                this.Invoke(txtCall, txt);
            }
            else
            {
               rc_chat.Text += txt + Environment.NewLine;
            }
        }

        public void Populator(string txt)
        {
            if (this.InvokeRequired)
            {
                SetTextCallBack txtCall = new SetTextCallBack(Populator);
                this.Invoke(txtCall, txt);
            }
            else
            {
                cb_serv.Items.Add(txt);
            }
        }

        private void tb_prefix_TextChanged(object sender, EventArgs e)
        {
            prefix = tb_prefix.Text;
            if (tb_prefix.Text == "")
            {
                
                tb_prefix.Text = "!";
                MessageBox.Show("Le préfix ne peut pas être null!");

            }
        }

        private void tb_logcommand_TextChanged(object sender, EventArgs e)
        {
            tb_logcommand.SelectionStart = tb_logcommand.Text.Length;
            tb_logcommand.ScrollToCaret();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string arg = cb_serv.Text;
            string separator = @"\";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();
            cb_channel.Enabled = true;
            cb_channel.Items.Clear();
            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            foreach (var item in guild.Channels)
            {
                try
                {
                    cb_channel.Items.Add(item.Name.ToString() + @"\" + item.Id.ToString());
                }
                catch (Exception)
                {




                }
            }
        }

        private void btn_deletechannel_Click(object sender, EventArgs e)
        {

            string arg = cb_serv.Text;
            string separator = @"\";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();
       
            var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
            foreach ( var chan in guild.Channels)
            {
                try
                {
                    chan.DeleteAsync();
                    SetText(DateTime.Now.ToString("h:mm:ss tt")+ "[COMMAND_SUCCESS]Le channel "+ chan.Name + " / "+ chan.Id.ToString() + " a bien été supprimé");
                }
                catch (Exception)
                {

                    SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_ERROR]N'a pas pu supprimer le channel :" + chan.Name.ToString() + "/"+ chan.Id.ToString() + "/ Permission refusée." );
                }
            }
            
        }

        private void btn_banall_Click(object sender, EventArgs e)
        {
            if (tb_input.Text == "Exemple : Message / Texte / Raison de ban")
            {
                MessageBox.Show("Vous devez inclure une raison dans le champ 'input' pour bannir des utilisateurs");
            }
            else
            {
                string arg = cb_serv.Text;
                string separator = @"\";
                char finalsep = char.Parse(separator);
                string[] guildseparated = arg.Split(finalsep);

                string guildresult = guildseparated[1].ToString();
             
                var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
                SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STARTED] Lancement du BanAll");
                foreach (var user in guild.Users)
                {
                    try
                    {
                        guild.AddBanAsync(user, 0, tb_input.Text);
                    }
                    catch (Exception)
                    {
                        //guild.AddBanAsync(user, 0, tb_input.Text);
                        SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_ERROR] Il est impossible de bannir " + user.Username.ToString() + "#" + user.Discriminator.ToString());

                    }
                }
                SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STOPPED] Fin du BanALL");

            }
           
        }

        private void lbl_chanmess_Click(object sender, EventArgs e)
        {
            string arg = cb_channel.Text;
            string separator = @"\";
            char finalsep = char.Parse(separator);
            string[] guildseparated = arg.Split(finalsep);

            string guildresult = guildseparated[1].ToString();


            try
            {
                var chan = _client.GetChannel(Convert.ToUInt64(guildresult)) as ITextChannel;
                chan.SendMessageAsync(tb_input.Text);
                SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_SUCCESS]Votre message sur le channel : "+ chan.Name+"/"+chan.Id.ToString() + " a bien été envoyé");
            }
            catch (Exception)
            {
                SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_ERROR]Le channel est peut être un channel Vocal");

            }
           

        }

        private void rc_chat_TextChanged(object sender, EventArgs e)
        {
            rc_chat.SelectionStart = rc_chat.Text.Length;
            rc_chat.ScrollToCaret();
           
        }

        private void tb_chanmessall_Click(object sender, EventArgs e)
        {
            if (tb_input.Text == "Exemple : Message / Texte / Raison de ban")
            {
                MessageBox.Show("Vous devez inclure un message à envoyer dans le champ 'input'");
            }
            else
            {
                string arg = cb_serv.Text;
                string separator = @"\";
                char finalsep = char.Parse(separator);
                string[] guildseparated = arg.Split(finalsep);

                string guildresult = guildseparated[1].ToString();

                var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
                int nb = Convert.ToInt16(tb_nbspam.Text);

                SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STARTED] Départ du spam");

                for (int i = 0; i < nb; i++)
                {
                  
                        try
                        {

                            foreach (Discord.ITextChannel chan in guild.Channels)
                            {

                                chan.SendMessageAsync(tb_input.Text);


                            }


                        }
                        catch (Exception)
                        {

                        SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_ERROR] Il est impossible d'écrire dans ce channel");
                        }
                }

                SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STOPPED] Le spam est terminé");
            }

        }

        private async void lbl_kickall_Click(object sender, EventArgs e)
        {
            if (tb_input.Text == "Exemple : Message / Texte / Raison de ban")
            {
                MessageBox.Show("Vous devez inclure un lien d'invitation discord dans le champs 'input'");
            }
            else
            {

                if (tb_input.Text.Contains("discord"))
                {
                    string arg = cb_serv.Text;
                    string separator = @"\";
                    char finalsep = char.Parse(separator);
                    string[] guildseparated = arg.Split(finalsep);

                    string guildresult = guildseparated[1].ToString();

                    var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
                    SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STARTED] L'invitation Link Bypass a démarré");
                    try
                    {
                        foreach (Discord.ITextChannel chan in guild.Channels)
                        {
                           var mess = await chan.SendMessageAsync("Ah");
                           await mess.ModifyAsync(t => {
                               t.Content = tb_input.Text;
                           });
                        }
                    }
                    catch (Exception)
                    {

                        SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_ERROR] Il est impossible d'envoyer ou de modifier certains messages");
                    }
                    SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STOPPED] Les actions de l'invitation link bypasser sont terminés");
                }
                else
                {
                    MessageBox.Show("Vous devez mettre un lien d'invitation discord Valide");
                }

            }
        }


        private void btn_createchan_Click(object sender, EventArgs e)
        {
            if (tb_input.Text == "Exemple : Message / Texte / Raison de ban")
            {
                MessageBox.Show("Vous devez inclure un nom de channel dans le champ 'Input'");
            }
            else
            {
                try
                {
                    string arg = cb_serv.Text;
                    string separator = @"\";
                    char finalsep = char.Parse(separator);
                    string[] guildseparated = arg.Split(finalsep);

                    string guildresult = guildseparated[1].ToString();

                    var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
                    int nb = Convert.ToInt16(tb_numchan.Text);
                    SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STARTED] Départ de la création de "+ nb.ToString() + " channel(s)");
                    for (int i = 0; i < nb; i++)
                    {
                        guild.CreateTextChannelAsync(tb_input.Text);
                    }

                    SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STOPPED] Fin de la création des channels");
                }
                catch (Exception)
                {
                    SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_ERROR] Il est impossible de créer un channel (Vérifiez vos permissions)");
                }
              
            }
        }

      

        private void btn_joua_Click(object sender, EventArgs e)
        {
            if (btn_joue.Text == "")
            {
                MessageBox.Show("Vous ne pouvez pas jouer à 'rien du tout'");
            }
            else
            {
                _client.SetGameAsync(btn_joue.Text,tb_joue_lien.Text,StreamType.Twitch);
            }
        }

       

        private void tb_save_logs_Click(object sender, EventArgs e)
        {
            saveFileDialog1.DefaultExt = ".txt";
           
            saveFileDialog1.ShowDialog();
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            string name = saveFileDialog1.FileName;
            File.WriteAllText(name, rc_chat.Text);
        }

        private void Connected_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btn_allmesspri_Click(object sender, EventArgs e)
        {


            if (tb_input.Text == "Exemple : Message / Texte / Raison de ban")
            {
                MessageBox.Show("Vous devez mettre un message dans le champ 'input' à envoyer à un utilisateur", "ERREUR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                string arg = cb_serv.Text;
                string separator = @"\";
                char finalsep = char.Parse(separator);
                string[] guildseparated = arg.Split(finalsep);

                string guildresult = guildseparated[1].ToString();

                var guild = _client.GetGuild(Convert.ToUInt64(guildresult));
                SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STARTED] Départ du DM ALL");
                try
                {
                    foreach (var user in guild.Users)
                    {
                        user.SendMessageAsync(tb_input.Text);
                    }
                }
                catch (Exception)
                {
                    SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_ERROR] Il est impossible d'envoyer un message à l'utilisateur ");

                }
                SetText(DateTime.Now.ToString("h:mm:ss tt") + "[COMMAND_STOPPED] Fin de la commande DM ALL");
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

    

        public void Btn_nitrogen_Click(object sender, EventArgs e)
        {
            if (NitroFormOpened == false)
            {
                 NitroGenerator gen = new NitroGenerator();

                 gen.Show();
                 NitroFormOpened = true;
            }
            else
            {

            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (NitroFormOpened == false)
            {
                btn_nitrogen.Enabled = true;
            }
            else
            {
                btn_nitrogen.Enabled = false;
            }
        }
    }

}

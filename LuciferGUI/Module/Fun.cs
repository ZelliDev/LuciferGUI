using Discord;
using Discord.Commands;
using Microsoft.CSharp;
using Newtonsoft.Json;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI.Module
{
    public class Fun : ModuleBase<SocketCommandContext>
    {
        [Command("randomuser")]
        public async Task RandomUser()
        {
            WebClient web = new WebClient();
            string json = web.DownloadString("https://randomuser.me/api/?nat=fr");
            API.RandomUserAPI.RootObject user = JsonConvert.DeserializeObject<API.RandomUserAPI.RootObject>(json);

            var embed = new EmbedBuilder();
            embed.WithTitle("Génération d'un utilisateur random");
            embed.WithThumbnailUrl(user.results[0].picture.large.ToString());
            
            embed.WithDescription("**Prenom** : "+user.results[0].name.first.ToString() + Environment.NewLine+
                "**Nom** : "+user.results[0].name.last.ToString() + Environment.NewLine+
                "**Âge** : "+user.results[0].registered.age.ToString()+Environment.NewLine+
                "**Date de naissance**"+user.results[0].registered.date.ToString() +Environment.NewLine+
                "**Sexe** : "+user.results[0].gender.ToString()+ Environment.NewLine+
                "**Nationnalité** : "+user.results[0].nat.ToString() + Environment.NewLine+
                "**État** :"+ user.results[0].location.state.ToString() + Environment.NewLine+
                "**Rue** : "+ user.results[0].location.street.ToString() + Environment.NewLine+
                "**Ville** : " + user.results[0].location.city.ToString() + Environment.NewLine+
                "**Code postal** : "+user.results[0].location.postcode.ToString()+ Environment.NewLine+
                "**Coordonnés** : "+user.results[0].location.coordinates.latitude.ToString()+"/"+user.results[0].location.coordinates.longitude.ToString()+Environment.NewLine+
                "**Adresse Email** : "+user.results[0].email.ToString()+Environment.NewLine+
                "**Fake Telephone**"+user.results[0].phone.ToString() +Environment.NewLine+ Environment.NewLine+
                "**Nom d'utilisateur** : "+user.results[0].login.username.ToString()+ Environment.NewLine+
                "**Mot de Passe** : "+user.results[0].login.password.ToString());
            await Context.Channel.SendMessageAsync("",false,embed);
        }

        [Command("email_gen")]
        public async Task EmailGenAsync()
        {

            WebClient client = new WebClient();
            string json = client.DownloadString("https://10minutemail.net/address.api.php?new=1");
            var result = JsonConvert.DeserializeObject<Email_Generation.RootObject>(json);
            var embed = new EmbedBuilder();
            embed.WithThumbnailUrl("https://media.giphy.com/media/YmjleYhDTUiYw/giphy.gif");
            embed.WithTitle(":cd: **Email 10 minutes généré ** :cd:");
            embed.WithDescription("__**Information du compte**__" + Environment.NewLine +
                "**Email : **" + result.mail_get_mail.ToString() + Environment.NewLine +
                "**Utilisateur : **" + result.mail_get_user.ToString() + Environment.NewLine +
                "**Session_ID : **" + result.session_id.ToString() + Environment.NewLine +
                "**KEY : **" + result.mail_get_key.ToString() + Environment.NewLine +
                "** Temps : **" + UnixTimeStampToDateTime(result.mail_get_time) + Environment.NewLine +
                "**Suppression du compte : **" + UnixTimeStampToDateTime(result.mail_get_duetime) + Environment.NewLine +
                "**PERMALINK : **" + result.permalink.url.ToString() + Environment.NewLine +
                "**Hôte : **" + result.mail_get_host.ToString() + Environment.NewLine);
            embed.WithColor(new Color(255, 0, 0));
            embed.WithFooter(Commands.version);
            await Context.Channel.SendMessageAsync("", false, embed);
        }

        [Command("porn")]
        public async Task PornAsync([Remainder]string arg)
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://api.redtube.com/?data=redtube.Videos.searchVideos&output=json&search="+arg+"");
            var result = JsonConvert.DeserializeObject<API.RedTubeAPI.RootObject>(json);
            var embed = new EmbedBuilder();
            int number = result.videos.Count;
            
            Random rdm = new Random();
            int randomLink = rdm.Next(0, number);

            embed.WithImageUrl(result.videos[randomLink].video.default_thumb.ToString());
            await Context.Channel.SendMessageAsync("",false,embed);
           
        }


        public static DateTime UnixTimeStampToDateTime(double unixTimeStamp)
        {
            // Unix timestamp is seconds past epoch
            System.DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Utc);
            dtDateTime = dtDateTime.AddSeconds(unixTimeStamp).ToLocalTime();
            return dtDateTime;
        }

        [Command("hack")]
        public async Task HackAsync([Remainder]IUser user)
        {
            await Context.Message.DeleteAsync();

            var embed = new EmbedBuilder();
            embed.WithTitle("**Hacking in progress.**");
            embed.WithDescription("**Communicating with DISCORD api...**" + Environment.NewLine+
                "**████ 20%**");

            var embed2 = new EmbedBuilder();
            embed2.WithTitle("**Hacking in progress..**");
            embed2.WithDescription("**Authentication in progress...**" + Environment.NewLine +
                "**████████ 40%**");

            var embed3 = new EmbedBuilder();
            embed3.WithTitle("**Hacking in progress...**");
            embed3.WithDescription("**Picking User Infos...**" + Environment.NewLine +
                "**████████████ 60%**");

            var embed4 = new EmbedBuilder();
            embed4.WithTitle("**Hacking in progress.**");
            embed4.WithDescription("**Searching in Public Database...**" + Environment.NewLine +
                "**████████████████ 80%**");


            var embed5 = new EmbedBuilder();
            embed5.WithTitle("**Hacking in progress..**");
            embed5.WithDescription("**Completed...**" + Environment.NewLine +
                "**████████████████████ 100%**");



            var mess = await Context.Channel.SendMessageAsync("", false, embed);
            System.Threading.Thread.Sleep(2000);

           await mess.ModifyAsync(x => { x.Embed = embed2.Build(); });

            System.Threading.Thread.Sleep(2000);

            await mess.ModifyAsync(x => { x.Embed = embed3.Build(); });

            System.Threading.Thread.Sleep(2000);

            await mess.ModifyAsync(x => { x.Embed = embed4.Build(); });

            System.Threading.Thread.Sleep(2000);

            await mess.ModifyAsync(x => { x.Embed = embed5.Build(); });
            System.Threading.Thread.Sleep(1000);


            var embed6 = new EmbedBuilder();
            embed6.WithThumbnailUrl(user.GetAvatarUrl());
            embed6.WithTitle("**Information sur : **"+ user.Username.ToString() + "#"+ user.Discriminator.ToString());
            embed6.WithDescription("**ID** : " + user.Id.ToString() + Environment.NewLine +
                "**Date de création** : " + user.CreatedAt.ToString() + Environment.NewLine+
                "**Joue à** : "+user.Game.ToString() + Environment.NewLine+
                "**Status** : "+user.Status.ToString()+ Environment.NewLine+ Environment.NewLine+
                "**Base64 first segment Token** : "+ Base64Encode(user.Id.ToString()));
            await mess.ModifyAsync(x => { x.Embed = embed6.Build(); });
        }

       
        [Command("dog")]
        public async Task RandomDogAsync()
        {
            WebClient client = new WebClient();
            string json = client.DownloadString("https://random.dog/woof.json");
            var result = JsonConvert.DeserializeObject<API.RandomDogImageAPI.RootObject>(json);

            var embed = new EmbedBuilder();
            embed.WithImageUrl(result.url.ToString());
            await Context.Channel.SendMessageAsync("",false, embed);
        }


        [Command("C#_compile")]
        public async Task CsharpCompileConsoleAppAsync(string name,[Remainder]string code)
        {
            string baseCode = @"using System; 
  
public class App { 
  
    static public void Main() 
    { 
  
        "+code+@"
       
     }
} ";

            CSharpCodeProvider codeProvider = new CSharpCodeProvider();
            ICodeCompiler icc = codeProvider.CreateCompiler();
            System.CodeDom.Compiler.CompilerParameters parameters = new CompilerParameters();
            parameters.GenerateExecutable = true;
            parameters.OutputAssembly = name;
           // parameters.ReferencedAssemblies.Add("lib/System.IO.FileSystem.dll");
            if (File.Exists(name))
            {
                File.Delete(name);
            }
            CompilerResults results = icc.CompileAssemblyFromSource(parameters, baseCode);

            if (results.Errors.Count > 0)
            {
                foreach (CompilerError CompErr in results.Errors)
                {
                    await Context.Channel.SendMessageAsync("Line number " + CompErr.Line +
                        ", Error Number: " + CompErr.ErrorNumber +
                        ", '" + CompErr.ErrorText + ";" +
                        Environment.NewLine + Environment.NewLine);
                       
                }
            }
            else
            {

                await Context.Channel.SendFileAsync(name, "**Compilation réussite**");
            }

        }

       

        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

    }
}

using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI.Module
{
    public class Commands :  ModuleBase<SocketCommandContext>
    {
        public static string version = "LuciferGUI [V1.3]";
        [Command("test")]
        public async Task TestAsync()
        {
            await Context.Channel.SendMessageAsync("OK test");
        }

        [Command("help")]
        public async Task HelpAsync(string arg = "")
        {
            string prefix = Connected.prefix;
            var embed = new EmbedBuilder();
            if (arg == "")
            {
                
                embed.WithTitle("Catégories des commandes");
                embed.WithThumbnailUrl("https://media.giphy.com/media/3oEjHJxLCoY8qFGUJW/source.gif");
                embed.WithColor(127,0,255);
                embed.WithFooter(version);
                embed.WithDescription(":computer: **Network** : __"+prefix +"help network__ pour voir les commandes réseau" + Environment.NewLine+
                    ":warning: **Modération** : __"+ prefix+"help moderation__ pour voir les commandes de modération" + Environment.NewLine+
                    ":fire: **Fun** : __"+ prefix+"help fun__ pour voir les commandes 'fun'" + Environment.NewLine+
                    ":pushpin: **Autres** : __" + prefix+"help autres__ pour voir les autres commandes");
                
            }
            if (arg == "network")
            {

                embed.WithTitle("Commandes Network");
                embed.WithThumbnailUrl("https://media.giphy.com/media/GuRuLWOGo0CI/giphy.gif");
                embed.WithColor(255,0,0);
                embed.WithDescription("**"+prefix+"ping (IP)** : faire un ping sur l'adresse IP" + Environment.NewLine+
                    "**"+prefix+"dns (IP)** : Faire un DnsLookup sur une IP ou un DNS" + Environment.NewLine+
                    "**"+prefix+"traceroute (IP)** : Faire un traceroute sur l'IP" + Environment.NewLine+
                    "**"+prefix+"reversedns (IP)** : Faire un ReverseDNS sur l'IP"+ Environment.NewLine+
                    "**"+prefix+"tcpscan (IP)** : Faire un scan des ports TCP sur l'IP" + Environment.NewLine+
                    "**"+prefix+"zonetransfer (DOMAINE)** : Faire un ZoneTransfer sur le Domaine" + Environment.NewLine+
                    "**"+prefix+"portscan (IP)** : Faire un PORTSCAN sur l'IP"+ Environment.NewLine+
                    "**"+prefix+"geoip (IP)** : Faire un GEOIP sur l'IP" + Environment.NewLine+
                    "**"+prefix+"phone (numero)** : Faire un lookup sur le numero de telephone" + Environment.NewLine+
                    "**"+prefix+"dnshistory (DOMAINE)** : Regarder les historiques d'un Domaine" + Environment.NewLine+
                    "**"+prefix+"cloudflare (DOMAINE)** : Faire un Cloudflare Resolver sur un domaine" + Environment.NewLine+
                    "");
                embed.WithFooter(version);


            }
            if (arg == "moderation")
            {
                embed.WithTitle("Commandes de Modération");
                embed.WithThumbnailUrl("https://media.giphy.com/media/m9rMVyKactNK/giphy.gif");
                embed.WithColor(51,255,51);
                embed.WithDescription("**"+prefix+"ban (Mention)** : Banni l'utilisateur mentionné"+Environment.NewLine+
                    "**"+prefix+"kick (Mention)** : Kick l'utilisateur mentionné" + Environment.NewLine+
                    "**"+prefix+"mute (Mention)** : Supprimera tous les messages envoyés par l'utilisateur mentionné"+Environment.NewLine+
                    "**"+prefix+"unmute (Mention)** : Enleve l'utilisateur mentionné de la liste des mutes");
                embed.WithFooter(version);
            
            }

            if (arg == "fun")
            {
                embed.WithTitle("Commandes fun");
                embed.WithThumbnailUrl("https://media.giphy.com/media/TLqkzhMIZxAQg/giphy.gif");
                embed.WithColor(0,128,255);
                embed.WithDescription("**"+prefix+"randomuser** : Génère un fake User via l'api de Randomuser.me" + Environment.NewLine+
                    "**"+prefix+"hack** : Génère un fake Hack"+ Environment.NewLine+
                    "**"+prefix+"email_gen** : Génère un Email 10 minutes" + Environment.NewLine+
                    "**"+prefix+"porn (categorie)* : Cherche une photo sur RedTube" + Environment.NewLine+
                    "**"+prefix+"C#_compile (CODE C#)** : Compile du code en C# et retourne le .exe" + Environment.NewLine+
                    "**"+prefix+"dog** : Envois une image random de chien");
                embed.WithFooter(version);
              
            }

            if (arg == "autres")
            {
                embed.WithTitle("Commandes Autres");
                embed.WithColor(255,255,255);
                embed.WithDescription("**"+prefix+"dev** : Envois les informations de développement");
                embed.WithFooter(version);
            }
           

            await Context.Channel.SendMessageAsync("",false, embed);
           
        }

    }
}

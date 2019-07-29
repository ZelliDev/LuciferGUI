using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI.Module
{
    public class Autres : ModuleBase<SocketCommandContext>
    {
        [Command("dev")]
        public async Task StatusAsync()
        {
            string UsageRam = API.ComputingAPI.CurrentAppUsingRam();
            string GetTotalRam = API.ComputingAPI.GetTotalRam();
            string CpuUsage = API.ComputingAPI.CurrentCPUusage();
            string luciferUsage = API.ComputingAPI.GetLuciferUSAGE();
            var embed = new EmbedBuilder();
            embed.WithThumbnailUrl("https://cdn.pixabay.com/photo/2013/07/12/18/15/terminal-153150_960_720.png");
            embed.WithTitle("**Developper informations**");
            embed.WithDescription("**Utilisation de RAM (LuciferGUI)** : " +UsageRam +" MB"+ Environment.NewLine+
                "**Mémoire RAM Totale **: "+GetTotalRam +" MB"+ Environment.NewLine+
                "**Current CPU ClockSpeed **: "+ CpuUsage + " GhZ" + Environment.NewLine+
                "**Current LuciferGUI CPU Usage** : "+ luciferUsage + "%" + Environment.NewLine + Environment.NewLine+
                "**Framework **: .Net Framework 4.7.2" + Environment.NewLine+
                "**Langage** : C#");
            await Context.Channel.SendMessageAsync("", false, embed);
        }
    }
}

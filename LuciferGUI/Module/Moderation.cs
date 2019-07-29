using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI.Module
{
    public class Moderation : ModuleBase<SocketCommandContext>
    {
        [Command("ban")]
        public async Task BanAsync(IGuildUser user,[Remainder]string raison)
        {
            await Context.Guild.AddBanAsync(user, 0, raison);
        }

        [Command("kick")]
        public async Task KickAsync(IGuildUser user)
        {
            await user.KickAsync();
        }
        
        [Command("mute")]
        public async Task MuteAsync(IUser user)
        {
            string id = user.Id.ToString();

            Connected.MuteList.Add(id);
        }

        [Command("unmute")]
        public async Task UnMuteAsync(IUser user)
        {
            string id = user.Id.ToString();
            Connected.MuteList.Remove(id);
        }

        

    }
}

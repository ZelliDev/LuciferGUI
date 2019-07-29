using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI.Module
{
    public class Network : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync(string ip)
        {
            string result = PingAPI.Ping(ip);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine+ result+ Environment.NewLine+"```");
        }

        [Command("traceroute")]
        public async Task TracerouteAsync(string ip)
        {
            string result = NetworkAPI.Traceroute(ip);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine+  result+Environment.NewLine+ "```");
        }

        [Command("dns")]
        public async Task DnsAsync(string ip)
        {
            string result = NetworkAPI.DnsLookup(ip);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine + result + Environment.NewLine+ "```");
        }

        [Command("reverse_dns")]
        public async Task ReverseDnsAsync(string ip)
        {
            string result = NetworkAPI.ReverseDnsLookup(ip);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine + result+ Environment.NewLine+"```");
        }

        [Command("tcpscan")]
        public async Task TcpScanAsync(string ip)
        {
            string result = NetworkAPI.Tcp_Scan(ip);
            await Context.Channel.SendMessageAsync("```css"+ Environment.NewLine+  result+Environment.NewLine+ "```");
        }

        [Command("zonetransfer")]
        public async Task ZoneTransferAsync(string domain)
        {
            string result = NetworkAPI.ZoneTransfer(domain);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine + result+ Environment.NewLine+"```");
        }

        [Command("portscan")]
        public async Task PortScanAsync(string ip)
        {
            string result = NetworkAPI.PortScan(ip);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine + result+ Environment.NewLine+"```");
        }

        [Command("geoip")]
        public async Task GeoIPAsync(string ip)
        {
            string result = NetworkAPI.GeoIP(ip);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine+result+Environment.NewLine +"```");
        }

        [Command("phone")]
        public async Task PhoneLookupAsync(string arg)
        {
            string result = NetworkAPI.PhoneLookup(arg);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine + result+Environment.NewLine+ "```");
        }

        [Command("dnshistory")]
        public async Task DnsHistoryAsync(string domain)
        {
            string result = NetworkAPI.DnsHistory(domain);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine+result+Environment.NewLine+"```");
        }

        [Command("cloudflare")]
        public async Task CloudflareResolverAsync(string domain)
        {
            string result = NetworkAPI.CloudflareResolver(domain);
            await Context.Channel.SendMessageAsync("```css"+Environment.NewLine + result+ Environment.NewLine+"```");
        }



    }
}


using CloudFlareUtilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LuciferGUI
{
    public partial class NitroGenerator : MetroFramework.Forms.MetroForm
    {
        public NitroGenerator()
        {
            InitializeComponent();
        }
        private int second = 0;
        public static string oldCode = string.Empty;
        private void NitroGenerator_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }


     


        private void RichTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.ScrollToCaret();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            second++;
            if (second == 3)
            {
                second = 0;
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[16];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }
                var finalString = new String(stringChars);
                if (oldCode == finalString)
                {



                }
                else
                {
                    string noExist = "{*code*: 10038, *message*: *Unknown Gift Code*}";
                    string noExistFinal = noExist.Replace('*', '"');
                    var handler = new ClearanceHandler();

                    handler.MaxRetries = 3;

                    var client = new HttpClient(handler);
                    ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

                    client.DefaultRequestHeaders.Add("User-Agent", "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/72.0.3626.109 Safari/537.36");

                    try
                    {

                        var content = client.GetStringAsync(new Uri("https://discordapp.com/api/v6/entitlements/gift-codes/" + finalString + "?with_application=false&with_subscription_plan=true")).Result;
                        richTextBox1.Text += finalString + " / EST UN BON CODE !" + Environment.NewLine;
                        File.WriteAllText("good.txt", finalString);
                    }


                    catch (Exception ex)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        richTextBox1.Text += finalString;
                        Console.ForegroundColor = ConsoleColor.White;
                        if (ex.InnerException.Message.Contains("404"))
                        {
                           richTextBox1.Text += " : Code nitro invalide" + Environment.NewLine;
                        }
                        if (ex.InnerException.Message.Contains("429"))
                        {
                            richTextBox1.Text += " : Trop de Requêtes / 429" + Environment.NewLine;
                        }
                    }
                }
            }
        }

        private void NitroGenerator_FormClosed(object sender, FormClosedEventArgs e)
        {
         
            timer1.Stop();
            Connected.NitroFormOpened = false;
           // this.Dispose();
        }
    }
}

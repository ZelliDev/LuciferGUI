using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuciferGUI
{
    public class Email_Generation
    {
        public class Permalink
        {
            public string host { get; set; }
            public string mail { get; set; }
            public string url { get; set; }
            public string key { get; set; }
            public int time { get; set; }
        }

        public class MailList
        {
            public string mail_id { get; set; }
            public string from { get; set; }
            public string subject { get; set; }
            public string datetime { get; set; }
            public string datetime2 { get; set; }
            public int timeago { get; set; }
            public bool isread { get; set; }
        }

        public class RootObject
        {
            public string mail_get_user { get; set; }
            public string mail_get_mail { get; set; }
            public string mail_get_host { get; set; }
            public int mail_get_time { get; set; }
            public int mail_get_duetime { get; set; }
            public int mail_server_time { get; set; }
            public string mail_get_key { get; set; }
            public int mail_left_time { get; set; }
            public object mail_recovering_key { get; set; }
            public object mail_recovering_mail { get; set; }
            public string session_id { get; set; }
            public Permalink permalink { get; set; }
            public List<MailList> mail_list { get; set; }
        }

    }
}

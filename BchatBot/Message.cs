using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BchatBot
{
    class Message
    {
        private string nick;
        private string cmd;
        private string chan;
        private string content;

        public Message(string message)
        {
            char[] charSeparator = new char[] { ' ' };
            string[] parts = message.Split(charSeparator, 4);

            System.Diagnostics.Debug.Write("Data : " + message);
            this.nick = parts[0];

            if (nick.Contains("!"))
            {
                nick = nick.Substring(1, nick.IndexOf("!")-1);
            }
            
            this.cmd = parts[1];
            this.chan = parts[2];
            this.content = parts[3].Substring(1, parts[3].Length-1);

            System.Diagnostics.Debug.WriteLine("");

            System.Diagnostics.Debug.WriteLine(content + " sent by " + nick +  " as a " + cmd + " on " + chan);
        }
    }
}

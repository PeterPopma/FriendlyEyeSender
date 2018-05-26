using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyEyeSender
{
    class SMS
    {
        public string sender;
        public List<SMSMessage> messages = new List<SMSMessage>();

        public SMS(string sender)
        {
            this.sender = sender;
        }
    }
}

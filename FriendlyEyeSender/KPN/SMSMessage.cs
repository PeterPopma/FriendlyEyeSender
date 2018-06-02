using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendlyEyeSender
{
    class SMSMessage
    {
        public string content;
        public string mobile_number;

        public SMSMessage(string content, string mobile_number)
        {
            this.content = content;
            this.mobile_number = mobile_number;
        }
    }
}

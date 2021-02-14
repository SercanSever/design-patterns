using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class MailSender : MessageSenderBase
    {
        public override void Send(MessageBody body)
        {
            Console.WriteLine("{0} was sent via MailSneder", body.Title);
        }
    }
}

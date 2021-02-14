using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class SmsSender : MessageSenderBase
    {
        public override void Send(MessageBody body)
        {
            Console.WriteLine("{0} was sent via SmsSender", body.Title);
        }
    }
}

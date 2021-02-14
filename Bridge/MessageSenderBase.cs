using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public abstract class MessageSenderBase
    {
        public void Save()
        {
            Console.WriteLine("Saved");
        }
        public abstract void Send(MessageBody body);
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Bridge
{
    public class CustomerManager
    {
        public MessageSenderBase MessageSenderBase { get; set; }
        public void UpdateCustomer()
        {
            MessageSenderBase.Send(new MessageBody { Title = "About the C#" });
            Console.WriteLine("Customer Updated!");
        }
    }
}

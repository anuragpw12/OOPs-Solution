using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Abstraction.AbstractClass
{
    public class SmsNotification: NotifcationAbstractClass
    {
        public SmsNotification(string message):base(message)
        {

        }

        public override void Send()
        {
            Console.WriteLine("Added SMS Logic and sms sent.");   
        }

    }
}

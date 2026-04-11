using OOP.Domain;
using OOP.Domain.Abstraction.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp
{
    public static class Abstract
    {
        public static void Run()
        {
            NotifcationAbstractClass s = new SmsNotification("Shipment Delivered");
            s.Validate();
            s.Send();
        }
        public static void Meaning()
        {
            Console.WriteLine("Exposing only essential feature and hiding implementation details.");
            Console.WriteLine("Achived using interface and abstract class.");
            Console.WriteLine("Abstract class = base class contains abstract method and concrete method both");
            Console.WriteLine("Eg. NotificationService - validate concrete and Send abstract where child class will implement");
            Console.WriteLine("sms, email has diffrent logics");
        }

    }
}

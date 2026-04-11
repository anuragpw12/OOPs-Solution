using OOP.Domain.Encapsulation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp.Encapsulation
{
    public static class Encapsulation
    {
        public static void Run()
        {
            Payment p = new Payment();
            p.ProcessPayment();

            //p.SetAmount(0);//Throws error
            p.SetAmount(10);
            p.ProcessPayment();

        }
        public static void Meaning()
        {
            Console.WriteLine("Restrict direct access to data and allow controlled access via methods.");
            Console.WriteLine("Implemented using private fields and properties (get/set).");
        }

    }
}

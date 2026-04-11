using OOP.Domain;
using OOP.Domain.Abstraction.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp.Abstraction.Interface
{
    public static class Interface
    {
        public static void Run()
        {
            IPaymentGateway sms = new RazorPayPaymentGateway();
            sms.ProcessPayment();
            sms.HandleResponse();
        }
        public static void Meaning()
        {
            Console.WriteLine("Interface defines a contract where implementing class must follow"); 
            Console.WriteLine("Interface are always public"); 
            Console.WriteLine("A contract must be accessible to consumers"); 
            Console.WriteLine("Note: Interfaces can now have static members and default (concrete) methods."); 


        }
    }
}

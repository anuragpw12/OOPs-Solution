using OOP.Domain.Inheritance;
using OOP.Domain.Polymorphism.CompileTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp.Polymorphism
{
    public class Polymorphism
    {
        public static void Run()
        {
            Console.WriteLine("\nRuntTime Polymorphism");
            Customer c = new Customer();
            c.status = 1;
            c.Message = "Failed";
            c.Log("Logic Failed");
            c.BuildMessage();


            Console.WriteLine("\nCompileTome Polymorphism");
            APIIntegration a = new APIIntegration();
            a.CallJsonRestSharp("TestAPIKey");
            a.CallJsonRestSharp("TestUser","TestPass");
             
        }

        public static void Meaning()
        {
            Console.WriteLine("Polymorphism in OOP means many forms");
            Console.WriteLine("Compile-Time Polymorphism - Method Overloading Eg. ApiIntegration class with diffrent RestsharpHandling some api key, user,password, auth.");
            Console.WriteLine("Runtime Polymorphism - Method Overriding - Eg. customer module iherit child and build its own message");
        
        }
    }
}

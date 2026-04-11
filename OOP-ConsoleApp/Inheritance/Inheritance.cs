using OOP.Domain.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp.Inheritance
{
    public class Inheritance
    {
        public static void Run()
        {
            Customer c = new Customer();
            c.status = 1;
            c.Message = "Failed";
            c.Log("Logic Failed"); 

            ModelResponse m = new ModelResponse();
            m.status = 0;
            m.Message = "Success";
            m.Log("Logic Success"); 
        }

        public static void Meaning()
        {
            Console.WriteLine("Inheritance - Child class reuses properties and behavior of parent class."); 
            Console.WriteLine("C# supports single, multilevel, and hierarchical inheritance through classes, \r\n\t  and supports multiple and hybrid inheritance through interfaces to avoid ambiguity and runtime complexity."); 
            Console.WriteLine("Runtime Polymorphism also achived."); 
            Console.WriteLine("Eg. ModelResponse where status and message, Log, BuildMessage(runtime polymorphism) - So customer,zone all will implement this"); 
        }

    }
}

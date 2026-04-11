using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Polymorphism.CompileTime
{
    public class APIIntegration
    {
        public void CallJsonRestSharp(string username,string password)
        {
            Console.WriteLine($"Handle API with username: {username} and password: {password}");
        }
        public void CallJsonRestSharp(string APIKey)
        {
            Console.WriteLine($"Handle API with APIKey:{APIKey}");
        }
         

    }
}

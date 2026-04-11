using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Inheritance
{
    public class Customer:ModelResponse
    {
        public override void BuildMessage()
        {
            Console.WriteLine($"Child build - Status: {status}, Message: {Message}");
        }

    }
}

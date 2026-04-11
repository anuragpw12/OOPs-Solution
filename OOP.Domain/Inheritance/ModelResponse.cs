using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Inheritance
{
    public class ModelResponse
    {
        public int status { get; set; }
        public string Message { get; set; }

        public void Log(string message)
        {
            Console.WriteLine("Log is created  - "+ message);
        }

        public virtual void BuildMessage()
        {
            Console.WriteLine($"Base build - Status: {status}, Message: {Message}");
        }
    }
}

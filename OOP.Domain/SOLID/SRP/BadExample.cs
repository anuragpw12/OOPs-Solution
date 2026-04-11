using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.SRP
{
    public class BadExample
    {
        public string Create()
        {
            return "Create Invoice";
        }
        public string Print()
        {
            return "Print Invoice";
        }
    }
}

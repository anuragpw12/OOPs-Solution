
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.LSP
{
    public class NoDiscount : IDiscount
    {
        public decimal Apply(decimal amount)
        {
            return amount;
        }
    }
}

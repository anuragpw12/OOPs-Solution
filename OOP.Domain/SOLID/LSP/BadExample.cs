using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.LSP
{
    public class BadExample
    {

        //base will return proper data 
        class Discount
        {
            public virtual decimal Apply(decimal amount)
            {
                return amount;
            }
        }

        //child class will give error so break
        class NoDiscount : Discount
        {
            public override decimal Apply(decimal amount)
            {
                throw new Exception("Not applicable");
            }
        }

    }
}

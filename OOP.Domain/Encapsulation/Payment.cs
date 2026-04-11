using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Encapsulation
{
    public class Payment
    {
        private decimal _amount;
        public decimal Amount
        {
            get => _amount;
            private set
            {
                if (value <= 0)
                    throw new ArgumentException("Amount must be greater than zero");

                _amount = value;
            }
        }

        public void SetAmount(decimal amount)
        {
            Amount = amount;
        }

        public void ProcessPayment()
        {
            Console.WriteLine($"Processing payment of {Amount}");
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Abstraction.Interface
{
    public class RazorPayPaymentGateway:IPaymentGateway
    {
        public void ProcessPayment()
        {
            Console.WriteLine("Initate Payment Process");
        }

        public void HandleResponse()
        {
            Console.WriteLine("Handle Response");
        }
    }
}

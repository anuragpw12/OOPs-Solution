using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.OCP
{
    public class RazorPayGateway : IPaymentGateway
    {
        public string ProcessPayment()
        {
            return "Payment Initiated successfully";
        }

        public string HandleResponse()
        {
            return "Response handled successfully";
        }

    }
}

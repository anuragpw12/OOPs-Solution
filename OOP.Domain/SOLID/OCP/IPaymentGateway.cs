using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.OCP
{
    public interface IPaymentGateway
    {
        string ProcessPayment();

        string HandleResponse();
    }
}

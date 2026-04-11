using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.Abstraction.Interface
{
    public interface IPaymentGateway
    {
        void ProcessPayment();
        void HandleResponse();
    }
}

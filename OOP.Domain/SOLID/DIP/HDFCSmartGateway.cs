using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.DIP
{
    public class HDFCSmartGateway : IDIPPaymentGateway
    {
        public string Initiate()
        {
            return "payment initiated";
        }
    }
}

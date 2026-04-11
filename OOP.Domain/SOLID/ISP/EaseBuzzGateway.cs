
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.ISP
{
    public class EaseBuzzGateway : IPayment, IStatus
    {
        public string Initiate()
        {
            return "Initiated succesfully";
        }

        public string Status()
        {
            return "Status from gateway";
        }
    }
}

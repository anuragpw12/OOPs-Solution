using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.OCP
{
    public class BadExample
    {
        public string ProcessPayment(string payname)
        {
            if (payname == "razorpay")
            {
                return "razorpay";
            }
            else if (payname == "easebuzz")
            {
                return "easebuzz";
            }

            return "";
        }

        public string HandleResponse(string payname)
        {
            if (payname == "razorpay")
            {
                return "razorpay";
            }
            else if (payname == "easebuzz")
            {
                return "easebuzz";
            }

            return "";
        }


    }
}

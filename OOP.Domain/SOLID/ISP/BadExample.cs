using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.SOLID.ISP
{
    public interface BadExample
    {
        string Payment();

        string Refund();

        string Status();
    }
}

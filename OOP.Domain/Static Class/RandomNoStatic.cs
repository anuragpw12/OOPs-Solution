using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain
{
    //Static class to generate random number
    //Created one instance of Random reason is it uses time-based seed - so If called quickly → same numbers repeat
    //I faced this issue in creating random number for order in smartgateway payment integration
    public static class RandomNoStatic
    {
        private static readonly Random _random = new Random(); 
        public static int Generate(int min,int max)
        {
            return _random.Next(min, max);
        }
        
    }
}

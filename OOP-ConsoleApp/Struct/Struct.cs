using OOP.Domain.Struct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp.Struct
{
    public static class Struct
    {
        public static void Run()
        {
            DimensionStruct d = new DimensionStruct(10,10,10);
            DimensionStruct d1 = d;

            d1.Length = 20;

            Console.WriteLine("Dimension 1 Length - " + d.Length);
            Console.WriteLine("Dimension 1 Width - " + d.Width);
            Console.WriteLine("Dimension 1 Height - " + d.Height);
            Console.WriteLine("---------------------------------");
            Console.WriteLine("Dimension 2 Length - " + d1.Length);
            Console.WriteLine("Dimension 2 Width - " + d1.Width);
            Console.WriteLine("Dimension 2 Height - " + d1.Height);
        } 

        public static void Meaning()
        {
            Console.WriteLine("Struct is a value type and stores small data and copied by value. Stores in stack");
        }
    }
}

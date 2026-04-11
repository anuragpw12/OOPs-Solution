using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP.Domain.ClassObjectConstructor
{
    //Normal class - Blueprint for creating objects
    public class Shipment
    {
        private static string Prefix { get; set; }
        public int Id { get; set; }
        public string AWBNo { get; set; }
        public string Source { get; set; }
        public string Destination { get; set; }

        //Static Constructor
        static Shipment()
        { 
            Console.WriteLine("i.Static Constructor \n------------------------\nHello I am Static Constructor called only once. if created multiple objects then also i wont get called.\n");
            Prefix = "AWB_";
        }

        //Instance Constructor
        public Shipment()
        {
            Console.WriteLine("ii.Default Constructor \n------------------------\nHello I am Instance Constructor\n");
            
            AWBNo = $"{Prefix}{RandomNoStatic.Generate(1, 100)}";
        }

        //Parameterized Constructor
        public Shipment(int Id, string Source, string Destination)
        {
            Console.WriteLine("iii.Parameterized Constructor - \n------------------------\nHello I am Parameterized Instance Constructor\n");

            AWBNo = $"{Prefix}{RandomNoStatic.Generate(1, 100)}";
            this.Id = Id;
            this.Source = Source;
            this.Destination = Destination;
        }

        //Copy Constructor
        public Shipment(Shipment s)
        {
            Console.WriteLine("iv.Copy Constructor - \n------------------------\nHello I am Copy Instance Constructor\n");
            AWBNo = s.AWBNo;
            Id = s.Id;
            Source = s.Source;
            Destination = s.Destination;
        }

        //void method
        public void GenerateShipment()
        {
            Console.WriteLine(AWBNo + " -> " + Id + " | " + Source + " | " + Destination);
            Console.WriteLine("\n------------------------\n");
        }
        


    }
}

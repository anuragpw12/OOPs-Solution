using OOP.Domain.ClassObjectConstructor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_ConsoleApp.ClassObjectConstructor
{
    public static class ClassObjectConstructor
    {
        public static void Run()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("Class, Object, Constructor - \n");

            Console.WriteLine("1.Normal Shipment Class:\n");

            //Static Constructor 
            //..Runs once when the class is accessed for the first time.

            // Default constructor 
            //..Runs every time object is created
            Shipment s1 = new Shipment();
            s1.GenerateShipment();

            // Parameterized constructor 
            //..Runs when an object is created with values passed as parameters.
            Shipment s2 = new Shipment(1, "Mumbai", "Bangalore");
            s2.GenerateShipment();

            // Copy Constructor
            //..Runs when a new object is created by copying values from an existing object.
            Shipment s3 = new Shipment(s2);
            s3.GenerateShipment();

            //Private Constructor
            //..Prevents object creation from outside the class.

            //Constructor Overloading
            //..Allows multiple constructors with different parameter lists in the same class

            //Constructor Chaining
            //..Calls one constructor from another constructor in the same class.
            Console.WriteLine("------------------------");
        }

        public static void Meaning()
        {
            Console.WriteLine("------------------------");
            Console.WriteLine("1.Class - ");
            Console.WriteLine("BluePrint that defines properties and method. Reference Type");
            Console.WriteLine("Eg,. Shipment Class");
            Console.WriteLine("Properties/Data = AWBNo,Source");
            Console.WriteLine("Method/Behaviour = GenerateShipment()");

            Console.WriteLine("-------------");
            Console.WriteLine("2.Object - ");
            Console.WriteLine("An instance of a class.");
            Console.WriteLine("Stores real data in HEAP and reference stored in stack.");
            Console.WriteLine("Eg,. Shipment s = new Shipment();");

            Console.WriteLine("-------------");
            Console.WriteLine("3.Constructor");
            Console.WriteLine("Special method called when object is created");
            Console.WriteLine("Main purpose to initialize default values, injecting required dependencies.");
            Console.WriteLine("C# Supports various types of constructor:-");
            Console.WriteLine("1. Static Constructor - Runs once when the class is accessed for the first time.");
            Console.WriteLine("2. Default Constructor - Runs every time object is created");
            Console.WriteLine("3. Parameterized Constructor - Runs when an object is created with values passed as parameters.");
            Console.WriteLine("4. Copy Constructor - Runs when a new object is created by copying values from an existing object.");
            Console.WriteLine("5. Private Constructor - Prevents object creation from outside the class.");
            Console.WriteLine("6. Constructor Overloading - Allows multiple constructors with different parameter lists in the same class.");
            Console.WriteLine("7. Constructor Chaining - Calls one constructor from another constructor in the same class.");

            Console.WriteLine("------------------------");

        }
       
    }
}

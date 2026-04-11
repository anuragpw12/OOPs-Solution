using OOP.Domain;
using OOP_ConsoleApp;
using OOP_ConsoleApp.Abstraction.Interface;
using OOP_ConsoleApp.ClassObjectConstructor;
using OOP_ConsoleApp.Encapsulation;
using OOP_ConsoleApp.Inheritance;
using OOP_ConsoleApp.Polymorphism;
using OOP_ConsoleApp.Struct;


while (true)
{
    Console.Clear();

    Console.WriteLine("Entry Point Of Console Application");
    Console.WriteLine("-----------------------------------");

    Console.WriteLine("1. Class Object Constructor");
    Console.WriteLine("2. Struct");
    Console.WriteLine("3. Encapsulation");
    Console.WriteLine("4. Abstraction - Abstract class");
    Console.WriteLine("5. Interface");
    Console.WriteLine("6. Inheritance");
    Console.WriteLine("7. Polymorphism");

    Console.Write("Select Topic (or press X to exit): ");
    string value = Console.ReadLine();

    if (value?.ToUpper() == "X")
        break;

    Console.Write("Do you want Meaning(M) or Run(R): ");
    string value2 = Console.ReadLine();

    switch (value)
    {
        case "1":
            if (value2?.ToUpper() == "R")
                ClassObjectConstructor.Run();
            else
                ClassObjectConstructor.Meaning();
            break;

        case "2":
            if (value2?.ToUpper() == "R")
                Struct.Run();
            else
                Struct.Meaning();
            break;

        case "3":
            if (value2?.ToUpper() == "R")
                Encapsulation.Run();
            else
                Encapsulation.Meaning();
            break;

        case "4":
            if (value2?.ToUpper() == "R")
                Abstract.Run();
            else
                Abstract.Meaning();
            break;

        case "5":
            if (value2?.ToUpper() == "R")
                Interface.Run();
            else
                Interface.Meaning();
            break;

        case "6":
            if (value2?.ToUpper() == "R")
                Inheritance.Run();
            else
                Inheritance.Meaning();
            break;

        case "7":
            if (value2?.ToUpper() == "R")
                Polymorphism.Run();
            else
                Polymorphism.Meaning();
            break;

        default:
            Console.WriteLine("Invalid Option");
            break;
    }

    Console.WriteLine("\nPress any key to continue...");
    Console.ReadKey(); // ⛔ waits before looping again
}


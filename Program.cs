using System;
using Prototype.Prototype;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prototype example");
            Console.WriteLine("Prototype is a creational design pattern that allows cloning objects, even complex ones, without coupling to their specific classes.");
            Console.WriteLine();

            Person p1 = new Person();
            p1.Age = 43;
            p1.BirthDate = Convert.ToDateTime("1976-01-01");
            p1.Name = "Stuart Shepherd";
            p1.IdInfo = new IdInfo(666);

            // perform a shallow copy of p1 and assign it to p2.
            Person p2 = p1.ShallowCopy();
            // make a deep copy of p1 and assign it to p3.
            Person p3 = p1.DeepCopy();

            // display values of p1, p2 and p3.
            Console.WriteLine("Original values of p1, p2, p3:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values:");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values:");
            DisplayValues(p3);

            // change the value of p1 properties and display the values of p1, p2 and p3.
            p1.Age = 20;
            p1.BirthDate = Convert.ToDateTime("2000-01-01");
            p1.Name = "John";
            p1.IdInfo.IdNumber = 7878;
            Console.WriteLine("\nValues of p1, p2 and p3 after changes to p1:");
            Console.WriteLine("   p1 instance values: ");
            DisplayValues(p1);
            Console.WriteLine("   p2 instance values (reference values have changed):");
            DisplayValues(p2);
            Console.WriteLine("   p3 instance values (everything was kept the same):");
            DisplayValues(p3);
        }

        public static void DisplayValues(Person p)
        {
            Console.WriteLine("      Name: {0:s}, Age: {1:d}, BirthDate: {2:MM/dd/yy}", p.Name, p.Age, p.BirthDate);
            Console.WriteLine("      ID#: {0:d}", p.IdInfo.IdNumber);
        }
    }
}

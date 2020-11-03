using System;

namespace DZ
{
    public class Class1
    {
        static void Main(string[] args)
        {

            Cat c = new Cat("Kot", new DateTime(2001, 01, 01));
            c.MakeNoise();
            Console.WriteLine($"Коту {c.Name} {c.GetAge()} лет");

        }
    }   }

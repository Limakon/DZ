using System;
using System.Collections.Generic;
using System.Text;

namespace DZ
{
    class Cat
    {
        public Cat(string name, DateTime berthday)
        {

            Name = name;
            Berthday = berthday;


        }

        public string Name
        {
            get;

            set;
        }
        public void MakeNoise()
        {

            Console.WriteLine($"{Name} мяукает");
        }
        public DateTime Berthday
        {
            get;

            set;

        }
        public int GetAge()
        {
            return (DateTime.Today - Berthday).Days / 365;

        }
    }
}
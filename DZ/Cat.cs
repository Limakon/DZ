using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
   public class Cat
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
        public byte HungryStatus
        {
            get { return _hungryStatus; }
            set
            {
                if (value < 0)
                {
                    _hungryStatus = 0;
                }
                else if (value > 100)
                {
                    _hungryStatus = 100;
                }
                else
                    _hungryStatus = value;
            }
        }
        public void Getstatus()
        {
            Console.WriteLine(Name);
            Console.WriteLine($"Возраст:{GatAge()}");
            if (HungryStatus <= 10)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Кошка умерает от голода:(");
            }
            else if (HungryStatus > 10 && HungryStatus <= 40)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Кошка очень голодна:")  ;
            }
            else if (HungryStatus >40  && HungryStatus <= 70)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine($"Кошка хочет кушать :");
            }
            else if (HungryStatus > 70 && HungryStatus <= 90)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Кошка не против перекусить:");
            }
            else if (HungryStatus > 90)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine($"Кошка недавно поела :(");
            }
            Console.ResetColor();

        }
        async Task LifeCircle()
        {
            await Task.Delay(1000);
            HungryStatus -= 10;
            Getstatus();
            if (HungryStatus == 0)
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Кошка умерла:(");
            }
            else
                await LifeCircle();
        }
    }
}
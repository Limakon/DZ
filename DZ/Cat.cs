using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DZ
{
    class Cat
    {
        byte _hungryStatus;
        public event EventHandler HungryStatusChanged;
        public Cat(string name, DateTime birthday)

        {
            Name = name;
            BirthDay = birthday;
            Task.Run(LifeCircle);
        }

        public string Name
        {
            get;
            set;
        }
        public void MakeNoise()
        {
            Console.WriteLine($"{Name } мяукает");
        }
        public DateTime BirthDay
        {
            get; set;
        }
        public int GetAge()
        {
            return (DateTime.Today - BirthDay).Days / 365;
        }

        public byte HungryStatus
        {
            get { return _hungryStatus; }
            set
            {
                byte status = value;
                if (status < 0)
                {
                    status = 0;
                }
                else if (status > 100)
                {
                    status = 100;
                }
                else
                    _hungryStatus = value;
                if (_hungryStatus != value)
                {
                    HungryStatusChanged?.Invoke(this, null);
                }

            }
        }

        public bool HungryStatys { get; private set; }

        public void Feed(byte needFood)
        {
            HungryStatus += needFood;
        }

        public string GetStatus(string color)

        {
            string name = Name;
            string age = Convert.ToString(GetAge());
            string status = Convert.ToString(HungryStatys);
            Console.WriteLine(Name);
            Console.WriteLine($"Возраст: {GetAge()}");
            if (HungryStatus < 10)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.DarkRed));
            }
            else if (HungryStatus > 10 && HungryStatus <= 40)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.Red));
            }
            else if (HungryStatus > 40 && HungryStatus <= 70)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.DarkYellow));
            }
            else if (HungryStatus > 40 && HungryStatus <= 70)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.Yellow));
            }
            else if (HungryStatus > 90)
            {
                color = Convert.ToString(Convert.ToInt32(Console.ForegroundColor = ConsoleColor.Green));
            }
            string getStatus = $"(color), (name), (age), (status)";
            return getStatus;
        }

        async Task LifeCircle()
        {

            await Task.Delay(100);
            HungryStatus -= 10;
            await LifeCircle();

        }

    }
}


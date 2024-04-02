using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Auto
    {
        public string Brand { get; set; }
        public Wheel Wheel { get; set; }
        public Engine Engine { get; set; }

        public Auto(string brand, Wheel wheel, Engine engine)
        {
            this.Brand = brand;
            this.Wheel = wheel;
            this.Engine = engine;
        }

        public void Go()
        {
            Console.WriteLine($"Автомобіль марки {Brand} їде.");
        }

        public void Refuel()
        {
            Console.WriteLine($"Автомобіль марки {Brand} заправляється.");
        }

        public void ReplaceWheel(Wheel newWheel)
        {
            this.Wheel = newWheel;
            Console.WriteLine($"Колесо автомобіля марки {Brand} замінено.");
        }



        public override bool Equals(object obj)
        {
            if (obj is Auto auto)
            {
                return this.Brand == auto.Brand &&
                       this.Wheel == auto.Wheel &&
                       this.Engine == auto.Engine;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Brand, Wheel, Engine);
        }

        public override string ToString()
        {
            return $"Автомобіль марки {Brand} з {Engine} і {Wheel}";
        }
    }
}

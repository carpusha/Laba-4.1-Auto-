using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Engine
    {
        public int Power { get; set; }

        public Engine(int power)
        {
            this.Power = power;

        }

        public override bool Equals(object? obj)
        {
            if (obj is Engine engine)
                return this.Power == engine.Power;
            return false;
        }

        public override int GetHashCode()
        {
            return Power.GetHashCode();
        }

        public override string ToString()
        {
            return $"Двигун потужністю: {Power}";
        }
    }

}


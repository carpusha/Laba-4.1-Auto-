using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp27
{
    internal class Wheel
    {
        public int Size { get; set; }

        public Wheel(int size)
        {
            this.Size = size;

        }

        public override bool Equals(object? obj)
        {
            if (obj is Wheel wheel)
                return this.Size == wheel.Size;
            return false;
        }

        public override int GetHashCode()
        {
            return Size.GetHashCode();
        }

        public override string ToString()
        {
            return $"Колесо розміром: {Size}";
        }
    }
}

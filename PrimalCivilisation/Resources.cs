using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimalCivilisation
{
    public class Resource : IGameResource
    {
        public double Value { get; set; }
        public int Max { get; set; }

        public Resource(double value, int max)
        {
            Value = value;
            Max = max;
        }

        public void Add(double value)
        {
            Value += value;
        }
    }
}

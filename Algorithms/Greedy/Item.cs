using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class Item
    {
        public int Value { get; set; }
        public int Weight { get; set; }

        public Item(int value, int weight)
        {
            Value = value;
            Weight = weight;
        }

        // This method calculates the value-to-weight ratio
        public double GetRatio()
        {
            return (double)Value / Weight;
        }
    }
}

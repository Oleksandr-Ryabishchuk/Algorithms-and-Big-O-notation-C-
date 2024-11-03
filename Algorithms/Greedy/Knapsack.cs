using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greedy
{
    public class Knapsack
    {
        public static double FractionalKnapsack(int capacity, List<Item> items)
        {
            // Sort items by value-to-weight ratio in descending order
            items.Sort((a, b) => b.GetRatio().CompareTo(a.GetRatio()));

            double totalValue = 0.0;
            int currentWeight = 0;

            foreach (var item in items)
            {
                if (currentWeight + item.Weight <= capacity)
                {
                    // Take the whole item
                    currentWeight += item.Weight;
                    totalValue += item.Value;
                }
                else
                {
                    // Take the fraction of the item that fits
                    int remainingCapacity = capacity - currentWeight;
                    totalValue += item.GetRatio() * remainingCapacity;
                    break;
                }
            }

            return totalValue;
        }
    }
}

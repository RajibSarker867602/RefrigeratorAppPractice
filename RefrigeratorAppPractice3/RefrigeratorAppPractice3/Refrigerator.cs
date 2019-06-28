using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefrigeratorAppPractice3
{
    class Refrigerator
    {
        public double MaximumWeight { get; set; }
        private double currentWeight;
                
        public double GetCurrentWight(int items,double weight)
        {
            if (items * weight > GetRemainingWeight())
            {
                return 0;
            }
            return currentWeight += items * weight;
        }
        public double GetRemainingWeight()
        {
            return MaximumWeight - currentWeight;
        }
    }
}

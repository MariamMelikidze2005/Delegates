using System;
using System.Collections.Generic;

namespace Homework
{
    public delegate int ComparisonDelegate<T>(T x, T y);  

    public static class MaxValue
    {
        public static T FindMaxValue<T>(List<T> list, ComparisonDelegate<T> comparison) where T : IComparable<T>
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("List cannot be empty.");
            }

            T max = list[0];  

            for (int i = 1; i < list.Count; i++) 
            {
                if (comparison(list[i], max) > 0) 
                {
                    max = list[i]; 
                }
            }

            return max;
        }
    }
}
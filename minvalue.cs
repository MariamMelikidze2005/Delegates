using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    //დაწერეთ ფუნქცია რომელიც ლისტში იპოვის ობიექტის მინიმალურ მნიშვნელობას.

    public delegate int ComparisonDelegate<T>(T x, T y);

    public static class MinValue
    {

        public static T FindMinValue<T>(List<T> list, ComparisonDelegate<T> comparison) where T : IComparable<T>
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("List cannot be empty.");
            }

            T min = list[0];
            for (int i = 1; i < list.Count; i++)
            {

                if (comparison(list[i], min) < 0)
                {
                    min = list[i];
                }
            }

            return min;
        }
    }
}
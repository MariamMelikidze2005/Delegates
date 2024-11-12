using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{

    public static class listHelper2
    {
        public delegate int ComparisonDelegate<T>(T x, T y);

        public static int FindLastIndex<T>(List<T> list, T item, ComparisonDelegate<T> comparison)
        {
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (comparison(list[i], item) == 0)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}

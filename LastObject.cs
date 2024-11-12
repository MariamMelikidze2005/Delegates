using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public static class FindLast
    {
        public delegate int ComparisonDelegate<T>(T x, T y);

        public static (T lastObject, int index) FindLastObjectWithIndex<T>(List<T> list, T item, ComparisonDelegate<T> comparison)
        {
            if (list.Count == 0)
            {
                return (default(T), -1);
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (comparison(list[i], item) == 0)
                {
                    return (list[i], i);
                }
            }

            return (default(T), -1);
        }
    }
}

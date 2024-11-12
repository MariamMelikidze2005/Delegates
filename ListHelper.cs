using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace homework
{
    public static class ListHelper
    {
        public delegate int ComparisonDelegate<T>(T x, T y);
        public static int FindFirstIndex<T>(List<T> list, T item, ComparisonDelegate<T> comparison)
        {
            for (int i = 0; i < list.Count; i++)
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

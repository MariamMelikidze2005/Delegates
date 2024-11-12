using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public static class FindAll
    {
        public delegate int ComparisonDelegate<T>(T x, T y);
        public static List<int> FindAllIndex<T>(List<T> list, T item, ComparisonDelegate<T> comparison)
        {
            var listofIndices = new List<int>(); 
            for (int i = 0; i < list.Count; i++)
            {
                if (comparison(list[i], item) == 0)
                {
                    listofIndices.Add(i);
                }
            }
            return listofIndices;
        }
    }
}

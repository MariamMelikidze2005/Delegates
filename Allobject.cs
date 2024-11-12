using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    // ფუნქცია რომელიც იპოვის ყველა ობიექტს და დააბრუნებს მათ ინდექსებს
    internal class AllObject
    {
        public delegate int ComparisonDelegate<T>(T x, T y);
        public static (List<int> indices, List<T> objects) FindAllObjectsWithIndex<T>(List<T> list, T item, ComparisonDelegate<T> comparison)
        {
            var listOfIndices = new List<int>();
            var listOfObjects = new List<T>();

            for (int i = 0; i < list.Count; i++)
            {
                if (comparison(list[i], item) == 0)
                {
                    listOfIndices.Add(i);
                    listOfObjects.Add(list[i]);
                }
            }

            return (listOfIndices, listOfObjects); 
        }
    }
}

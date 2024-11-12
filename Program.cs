using homework;
using Homework;
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //1
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //ListHelper.ComparisonDelegate<int> comparison = (x, y) => x.CompareTo(y);
        //int index = ListHelper.FindFirstIndex(numbers, 3, comparison);
        //Console.WriteLine("Index of 3: " + index);

        //List<string> words = new List<string> { "kafka", "dostoevsky", "dochanashvili" };
        //int wordIndex = ListHelper.FindFirstIndex(words, "dochanashvili", (x, y) => x.CompareTo(y));
        //Console.WriteLine("Index of 'dochanashvili': " + wordIndex);

        //int notFoundIndex = ListHelper.FindFirstIndex(numbers, 10, (x, y) => x.CompareTo(y));
        //Console.WriteLine("Index of 10: " + notFoundIndex);


        //2

        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 3, 2, 3 };
        //listHelper2.ComparisonDelegate<int> comparison = (x, y) => x.CompareTo(y);
        //int lastIndex = listHelper2.FindLastIndex(numbers, 3, comparison);
        //Console.WriteLine($"Last index of 3: {lastIndex}");

        //3
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 3, 5, 3 };
        //FindAll.ComparisonDelegate<int> comparison = (x,y) => x.CompareTo(y);
        //var indices = FindAll.FindAllIndex(numbers, 3, comparison);

        //Console.WriteLine("Indices of 3: " + string.Join(" , ", indices));



        //5
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        //FindLast.ComparisonDelegate<int> comparison = (x, y) => x.CompareTo(y);
        //var lastNumber = FindLast.FindLastObjectWithIndex(numbers,3, comparison);
        //Console.WriteLine("Last object: " + lastNumber.lastObject + "Last index: " + lastNumber.index);

        //List<string> words = new List<string> { "kafka", "dostoevsky", "dochanashvili", "dostoevsky" };
        //var lastWord = FindLast.FindLastObjectWithIndex(words, "dostoevsky", (x, y) => x.CompareTo(y));
        //Console.WriteLine("Last object: " + lastWord.lastObject + "Last index: " + lastWord.index);


        //List<string> emptyList = new List<string>();
        //var notFound = FindLast.FindLastObjectWithIndex(emptyList, "dostoevsky", (x, y) => x.CompareTo(y));
        //Console.WriteLine("Last object: " + notFound.lastObject);
        //Console.WriteLine("Last index: " + notFound.index);

        //6
        //List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 3, 2, 3 };
        //AllObject.ComparisonDelegate<int> comparison = (x,y) => x.CompareTo(y);
        //var result = AllObject.FindAllObjectsWithIndex(numbers, 3, comparison);
        //Console.WriteLine("Found objects:");
        //for (int i = 0; i < result.objects.Count; i++)
        //{
        //    Console.WriteLine($"Object: {result.objects[i]}, Index: {result.indices[i]}");
        //}

        //7
        //List<int> numbers = new List<int> { 1, 5, 3, 9, 2 };
        //int maxValue = MaxValue.FindMaxValue(numbers, (x, y) => x.CompareTo(y));
        //Console.WriteLine($"Maximum value: {maxValue}");

        //8

        List<int> numbers = new List<int> { 1, 5, 3, 9, 2 };
        int minValue = MinValue.FindMinValue(numbers, (x, y) => x.CompareTo(y));
        Console.WriteLine($"Minimum value: {minValue}");


    }
}

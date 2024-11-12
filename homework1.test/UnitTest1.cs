using System;
using System.Collections.Generic;
using Xunit;
using homework;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace homework1.test
{
    public class MinValueTests
    {
        [Fact]
        public void ShouldThrowArgumentException()
        {
            // Arrange
            var emptyList = new List<int>();
            ComparisonDelegate<int> comparison = (x, y) => x.CompareTo(y);

            // Act & Assert
            Assert.Throws<ArgumentException>(() => homework.MinValue.FindMinValue(emptyList, comparison));
        }
        [Fact]
        public void FindMinValue_This_function_should_return_Min_Integer()
        {
            // Arrange
            var numbers = new List<int> { 5, 3, 8, 1, 4 };
            ComparisonDelegate<int> comparison = (x, y) => x.CompareTo(y); 

            // Act
            int minValue = MinValue.FindMinValue(numbers, comparison);

            // Assert
            Assert.Equal(1, minValue);
        }


        [Fact]
        public void FindMinValue_This_function_should_return_MIn_String()
        {
            // Arrange
            var words = new List<string> { "kafka", "dostoevsky", "dochanashvili", "dostoevsky" };
            ComparisonDelegate<string> comparison = (x, y) => x.CompareTo(y);

            // Act
            string minValue = homework.MinValue.FindMinValue(words, comparison);

            // Assert
            Assert.Equal("dochanashvili", minValue);
        }


       

    }
}

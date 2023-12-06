using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var evens = new List<int>();
            var odds = new List<int>();

            for (int i = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
                else
                {
                    odds.Add(numbers[i]);
                }
            }

            return evens.Sum() - odds.Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var stringLength = new List<int>() {str1.Length, str2.Length, str3.Length, str4.Length};
            return stringLength.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            var numList = new List<int>() {number1, number2, number3, number4};
            return numList.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }
        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            var sides = new List<int> { sideLength1, sideLength2, sideLength3 };
            var canTriangle = sides.Sum() - sides.Max();

            if (canTriangle > sides.Max())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsStringANumber(string input)
        {
            var isNumber = double.TryParse(input, out var number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var majority = (objs.Length / 2) + 1;
            var nullCount = 0;

            foreach ( var obj in objs )
            {
                if (obj == null)
                {
                    nullCount++;
                }
            }
            return nullCount >= majority ? true : false; 
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var evens = new List<int>();

            for (int i  = 0; i < numbers.Length; i++) 
            {
                if (numbers[i] % 2 == 0)
                {
                    evens.Add(numbers[i]);
                }
            }
            return (evens == null || evens.Count == 0) ? 0 : evens.Average();
        }

        public int Factorial(int number)
        {
            if (number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            else if (number == 0)
            {
                return 1;
            }
            return number * Factorial(number - 1);
        }
    }
}

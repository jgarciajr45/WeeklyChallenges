using System;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            int result = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    result += number;
                }
                else
                {
                    result -= number;
                }
            }

            return result;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            int Length1 = str1.Length;
            int length2 = str2.Length;
            int length3 = str3.Length;
            int length4 = str4.Length;

            int shortestLength = Math.Min(Math.Min(Length1, length2), Math.Min(length3, length4));

            return shortestLength;
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            int smallest = number1;
            if (number2 < smallest)
            {
                smallest = number2;
            }
            if (number3 < smallest)
            {
                smallest = number3;
            }
            if (number4 < smallest)
            {
                smallest = number4;
            }
            return smallest;
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            if (sideLength1 <= 0 || sideLength2 <= 0 || sideLength3 <= 0)
            {
                return false;
            }

            if (sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength2 + sideLength3 > sideLength1)
            {
                return true;
            }

            return false;
        }

        public bool IsStringANumber(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            bool isNumber = double.TryParse(input, out _);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            int countNull = 0;
            int countNotNull = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    countNull++;
                }
                else
                {
                    countNotNull++;
                }
            }
            return countNull > countNotNull;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            var evenNumbers = numbers.Where(n => n % 2 == 0).ToArray();

            if (evenNumbers.Length == 0)
            {
                return 0;
            }

            double average = evenNumbers.Average();

            return average;
        }

        public int Factorial(int number)
        {
            int result = 1;
            for (int i = 2; i <= number; i++)
            {
                result *= i;
            }

            return result;

        }

        
    }
}

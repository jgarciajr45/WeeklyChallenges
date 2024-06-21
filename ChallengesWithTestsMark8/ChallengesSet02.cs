using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            if ((c >= 'A' && c <= 'Z') || (c >= 'a' && c <= 'z'))
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            throw new NotImplementedException();
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            throw new NotImplementedException();
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || !numbers.Any())
            {
                return 0;
            }
            double min = numbers.Min();
            double max = numbers.Max();

            return min + max;

            throw new NotImplementedException();
        }


        public int GetLengthOfShortestString(string str1, string str2)
        {
            int length1 = str1.Length;
            int length2 = str2.Length;
            return Math.Min(length1, length2);
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
                int total = 0;
            foreach (int number in numbers)
            {
                total += number;
            }
            return total;
            throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    sum += number;
                }
            }

            return sum;
        
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null || numbers.Count == 0)
            {
                return false;
            }

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum % 2 != 0;

            throw new NotImplementedException();
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number <= 1)
            {
                return 0;
            }

            long count = number / 2;

            return count;
            throw new NotImplementedException();
        }
    }
}

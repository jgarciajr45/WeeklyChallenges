using System;
using System.Collections.Generic;
using System.Text;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            int nextNumber = startNumber + 1;

            while (nextNumber % n != 0)
            {
                nextNumber++;
            }

            return nextNumber;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            if (businesses == null || businesses.Length == 0)
            {
                return;
            }
            foreach (var business in businesses)
            {
                if (business.TotalRevenue == 0)
                {
                    business.Name = "CLOSED";
                }
            }

        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return false;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }

            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 0; i < numbers.Length - 1; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    sum += numbers[i + 1];
                }
            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";
            }

            StringBuilder sentenceBuilder = new StringBuilder();

            foreach (var word in words)
            {
                if (!string.IsNullOrWhiteSpace(word))
                {
                    if (sentenceBuilder.Length > 0)
                    {
                        sentenceBuilder.Append(" ");
                    }
                    sentenceBuilder.Append(word.Trim());
                }
            }

            string sentence = sentenceBuilder.ToString();
            if (sentence.Length > 0)
            {
                sentence += ".";
            }

            return sentence;
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];
            }

            List<double> everyFourthElement = new List<double>();

            for (int i = 3; i < elements.Count; i += 4)
            {
                everyFourthElement.Add(elements[i]);
            }

            return everyFourthElement.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length < 2)
            {
                return false;
            }

            HashSet<int> seenNumbers = new HashSet<int>();

            foreach (int num in nums)
            {
                int complement = targetNumber - num;

                if (seenNumbers.Contains(complement))
                {
                    return true;
                }

                seenNumbers.Add(num);
            }

            return false;
        }
    }
}

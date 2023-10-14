using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {

            return Char.IsLetter(c);

        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            return vals.Length % 2 == 0;
        }

        public bool IsNumberEven(int number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            return false;
        }

        public bool IsNumberOdd(int num)
        {
            if (num % 2 != 0)
            {
                return true;
            }
            return false;
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            if (numbers == null || numbers.Count() == 0)
            {
                return 0;
            }

            return numbers.Min() + numbers.Max();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            var word1 = str1.Length;
            var word2 = str2.Length;

            if (word1 < word2)
            {
                return word1;
            }
            else
            {
                return word2;
            }
        }

        public int Sum(int[] numbers)
        {
            var sum = 0;
            if(numbers == null || numbers.Length == 0) { return 0; }
            foreach (var number in numbers) 
            {
                sum += number;
            }
            return sum;
        }

        public int SumEvens(int[] numbers)
        {
            var sum = 0;
            if (numbers == null)
            {
                return 0;
            }
            foreach (var number in numbers)
            {
                if (number % 2 == 0)
                {
                   
                    sum += number;
                }
            }

            return sum;



        }

        public bool IsSumOdd(List<int> numbers)
        {
            if (numbers == null)
            {
                return false;
            }
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }
            if (sum % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            if (number < 0)
            {
                return 0;
            }
            return number / 2;
        }
    }
}

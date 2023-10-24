using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)
        {
            if (vals.Contains(false)) return true; return false;

        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)
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

        public bool PasswordContainsUpperLowerAndNumber(string password)
        {
            if (password.Any(char.IsUpper) && password.Any(x => x >= 0))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public char GetFirstLetterOfString(string val)
        {
            return val.ToCharArray()[0];
        }

        public char GetLastLetterOfString(string val)
        {
            return val[val.Length - 1];
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }
            return dividend / divisor;
        }

        public int LastMinusFirst(int[] nums)
        {
            if (nums.Length > 0)
            {
                return nums[nums.Length - 1] - nums[0];
            }
            return 0;

        }

        public int[] ShouldGetOddsBelow100()
        {
            List<int> odds = new List<int>();
            for (int i = 1; i < 100; i += 2)
            {
                odds.Add(i);
            }

            return odds.ToArray();
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            string[] values = words.Select(word => word.ToUpper()).ToArray();
            
        }
    }
}

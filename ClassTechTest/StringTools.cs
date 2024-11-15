﻿using System.Collections.Generic;

namespace ClassTechTest
{
    public class StringTools
    {
        #region String Tool Problems

        public string FindFirstDuplicatedCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var existedChars = new HashSet<char>();
            foreach (var charValue in input)
            {
                var lowerChar = char.ToLower(charValue);
                var upperChar = char.ToUpper(charValue);

                if (existedChars.Contains(lowerChar))
                {
                    return lowerChar.ToString();
                }

                if (existedChars.Contains(upperChar))
                {
                    return upperChar.ToString();
                }

                existedChars.Add(charValue);
            }

            return null;
        }

        #endregion

        #region Palindrome Problems

        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            int leftIndex = 0;
            int rightIndex = input.Length - 1;

            while (leftIndex < rightIndex)
            {
                if (char.ToLower(input[leftIndex]) != char.ToLower(input[rightIndex]))
                {
                    return false;
                }
                leftIndex++;
                rightIndex--;
            }

            return true;
        }

        public string FindLargestPalindrome(string input)
        {
            return null;
        }

        #endregion
    }
}

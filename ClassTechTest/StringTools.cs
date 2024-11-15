using System.Collections.Generic;

namespace ClassTechTest
{
    public class StringTools
    {
        #region String Tool Problems

        /// <summary>
        /// Find first duplicated character in <paramref name="input"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>First duplicated character.</returns>
        public string FindFirstDuplicatedCharacter(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            var existedChars = new HashSet<char>();
            foreach (var charValue in input)
            {
                // check whether this character has appeared before, regardless of whether it's uppercase or lowercase
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

                // store the first appearance of the character, regardless of whether it's uppercase or lowercase
                existedChars.Add(charValue);
            }

            return null;
        }

        #endregion

        #region Palindrome Problems

        /// <summary>
        /// Check <paramref name="input"/> is a palindrome.
        /// </summary>
        /// <param name="input"></param>
        /// <returns><c>true</c> if <paramref name="input"/> is a palindrome. Otherwise <c>false</c>.</returns>
        public bool IsPalindrome(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
            {
                return false;
            }

            // move leftIndex from left to right, and rightIndex in opposite direction
            int leftIndex = 0;
            int rightIndex = input.Length - 1;

            while (leftIndex < rightIndex)
            {
                // any mismatch between left and right character => input is not a palindrome
                if (char.ToLower(input[leftIndex]) != char.ToLower(input[rightIndex]))
                {
                    return false;
                }
                leftIndex++;
                rightIndex--;
            }

            return true;
        }

        /// <summary>
        /// Find the longest palindrome in <paramref name="input"/>.
        /// </summary>
        /// <param name="input">Input string.</param>
        /// <returns>The longest palindrome.</returns>
        public string FindLargestPalindrome(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return null;
            }

            if (input.Length == 1)
            {
                return input;
            }

            // start with the longest possible substring to the shortest substring
            var subStringLength = input.Length;
            while (subStringLength > 1)
            {
                // check every substrings of the input with length = subStringLength
                for (var startIndex = 0; startIndex + subStringLength <= input.Length; startIndex++)
                {
                    var subString = input.Substring(startIndex, subStringLength);
                    if (IsPalindrome(subString))
                    {
                        return subString;
                    }
                }
                subStringLength--;
            }

            return null;
        }

        #endregion
    }
}

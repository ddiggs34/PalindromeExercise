using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeExercise
{
    public class Wordsmith
    {

        public bool IsAPalindrome(string word)
        {
            var palindrome = "";
            
            for (int i = word.Length - 1; i >= 0; i--) //formula to go reversed
            {
                palindrome += word[i];
            }

            if (word.ToUpper() == palindrome.ToUpper())
            {
                return true;
            }
            else
            { return false; }
        }
    }
}

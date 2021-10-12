using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Diagnostics;
using System.Linq;

namespace ConsoleApp
{
    public class Test_02
    {
        public Test_02()
        {
            //A palindrome is a word, phrase, verse, or sentence that reads the same backward or forward.Only the order of English alphabet letters(A - Z and a - z)
            //should be considered, other characters should be ignored. For example, IsPalindrome("Noel sees Leon.") should return true as spaces, period, and case
            //should be ignored resulting with "noelseesleon" which is a palindrome since it reads same backward and forward.

            IsValidPalindrome("A man, a plan, a canal: Panama.", true, "Test_02 : Test1");
            IsValidPalindrome("A Toyota. Race fast, safe car. A Toyota.", true, "Test_02 : Test2");
            IsValidPalindrome("Draw, O coward!", true, "Test_02 : Test3");
            IsValidPalindrome("Murder for a jar of red rum.", true, "Test_02 : Test4");
            IsValidPalindrome("Was it a car or a cat I saw?", true, "Test_02 : Test5");
            IsValidPalindrome("...Test", false, "Test_02 : Test6");
            IsValidPalindrome("This article is not useful.", false, "Test_02 : Test7");
            IsValidPalindrome("Dot Net Perls is not a palindrome.", false, "Test_02 : Test8");
            IsValidPalindrome("Why are you reading this?", false, "Test_02 : Test9");
        }

        public void IsValidPalindrome(string testString, bool isValid, string message)
        {
            try
            {
                Assert.AreEqual(CheckPalindrome(testString), isValid, message);
            }
            catch (Exception e)
            {
                Debug.WriteLine("");
                Debug.WriteLine(e.Message);
            }
        }


        public bool CheckPalindrome(string testString)
        {
            //YOUR CODE GOES HERE, MAKE ALL ASSERT TESTS PASS

            string letterString = "";
            foreach (char ch in testString.ToLower())
            {
                if (char.IsLetter(ch))
                {
                    letterString = letterString + ch;
                }
            }

            char[] charArr1 = letterString.ToCharArray();
            Array.Reverse(charArr1);
            string letterStringInv = new string(charArr1);

            if (letterString == letterStringInv)
            {
                Console.WriteLine($"{testString} = OK");
                return true;
            }
            else
            {
                Console.WriteLine($"{testString} = EJ OK");
                return false;
            }
        }


    }
}

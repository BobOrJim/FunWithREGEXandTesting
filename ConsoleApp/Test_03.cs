using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp
{
    public class Test_03
    {

        public Test_03()
        {
            //Nedan är start och slutsiffra för en nummerserie.
            //Om digit är med talet, skall talet adderas till summa.

            IsValidSum(100, 102, 2, 102, "Test_03 : Test1");
            IsValidSum("A Toyota. Race fast, safe car. A Toyota.", true, "Test_02 : Test2");
            IsValidSum("Draw, O coward!", true, "Test_02 : Test3");
            IsValidSum("Murder for a jar of red rum.", true, "Test_02 : Test4");
            IsValidSum("Was it a car or a cat I saw?", true, "Test_02 : Test5");
            IsValidSum("...Test", false, "Test_02 : Test6");
            IsValidSum("This article is not useful.", false, "Test_02 : Test7");
            IsValidSum("Dot Net Perls is not a palindrome.", false, "Test_02 : Test8");
            IsValidSum("Why are you reading this?", false, "Test_02 : Test9");
        }
        //serieNr summa

        public void IsValidSum(int start, int end, int digit)
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


    }
}

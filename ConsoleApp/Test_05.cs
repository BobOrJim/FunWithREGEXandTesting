using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using ConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp
{
    public class Test_05
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
        public Test_05()
        {
            //4: Bygg funktion som kör bitmask AND på första och andra siffran och kontrollerar om summan stämmer med siffra3.

            IsValidBitWiseAnd(16, 17, 16, true, "Test_04 : Test1");
            IsValidBitWiseAnd(100, 200, 64, true, "Test_04 : Test2");
            IsValidBitWiseAnd(1000, 2000, 960, true, "Test_04 : Test3");

            IsValidBitWiseAnd(255, 254, 1, false, "Test_04 : Test5");
            IsValidBitWiseAnd(0, 0, 1, false, "Test_04 : Test6");

        }

        public void IsValidBitWiseAnd(int tal1, int tal2, int sum, bool isValid, string message)
        {
            try
            {
                Assert.AreEqual(BitWiseAnd(tal1, tal2, sum), isValid, message);
            }
            catch (Exception e)
            {
                Debug.WriteLine("");
                Debug.WriteLine(e.Message);
            }
        }

        public bool BitWiseAnd(int tal1, int tal2, int sum)
        {
            //YOUR CODE GOES HERE, MAKE ALL ASSERT TESTS PASS

            var tal = tal1 & tal2;


            if (tal == sum)
            {
                Console.WriteLine($"tal: {tal}. sum: {sum} = OK");
                return true;
            }
            else
            {
                Console.WriteLine($"tal: {tal}. sum: {sum} = EJ OK");
                return false;
            }
        }

    }
}

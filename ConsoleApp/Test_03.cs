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
            //Nedan är start och slutsiffra för en nummerserie. Tex 100, 101, 102.
            //Om digit är med talet, skall talet adderas till en beräknad summa.
            //Om beräknad summa matchar sista siffran, är testet sant.

            IsValidSum(100, 102, 2, 102, true, "Test_03 : Test1"); //startsiffraISerie, slutsiffraISerie, digitAttLetaEfter, summaAvTalDärDigitIngår.
            IsValidSum(1, 20, 9, 28, true, "Test_03 : Test2");
            IsValidSum(50, 59, 5, 545, true, "Test_03 : Test3");
            IsValidSum(100, 200, 9, 3286, true, "Test_03 : Test4");

            IsValidSum(1, 8, 9, 100, false, "Test_03 : Test5");
            IsValidSum(99, 199, 9, 1000, false, "Test_03 : Test6");

        }

        public void IsValidSum(int start, int end, int digit, int sum, bool isValid, string message)
        {
            try
            {
                Assert.AreEqual(CheckSum(start, end, digit, sum), isValid, message);
            }
            catch (Exception e)
            {
                Debug.WriteLine("");
                Debug.WriteLine(e.Message);
            }
        }

        public bool CheckSum(int start, int end, int digit, int sum)
        {
            //YOUR CODE GOES HERE, MAKE ALL ASSERT TESTS PASS
            int accSum = 0;

            for (int i = start; i <= end; i++)
            {
                if (i.ToString().Contains(digit.ToString()))
                {
                    accSum += i;
                }
            }

            if (accSum == sum)
            {
                Console.WriteLine($"accSum: {accSum}. sum: {sum} = OK");
                return true;
            }
            else
            {
                Console.WriteLine($"accSum: {accSum}. sum: {sum} = EJ OK");
                return false;
            }
        }

    }
}

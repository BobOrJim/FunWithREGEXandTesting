using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Test_01
    {
        public Test_01()
        {
            //A valid serial number, has 2-3 digits, 3 letters, 2-3 digits
            IsValidSerialNr("bannan", false, "Test_01 : Test1");
            IsValidSerialNr("22aaa22", true, "Test_01 : Test2");
            IsValidSerialNr("22aaa333", true, "Test_01 : Test3");
            IsValidSerialNr("333aaa22", true, "Test_01 : Test4");
            IsValidSerialNr("333aaa333", true, "Test_01 : Test5");
            IsValidSerialNr("bbbbaac333333333", false, "Test_01 : Test6");
            IsValidSerialNr("88aaaa111", false, "Test_01 : Test7");
            IsValidSerialNr("333aaa3331", false, "Test_01 : Test8");
            IsValidSerialNr("bannan", false, "Test_01 : Test9");
        }

        public void IsValidSerialNr(string serialNumber, bool isValid, string message)
        {
            try
            {
                Assert.AreEqual(CheckSerialNr(serialNumber), isValid, message);
            }
            catch (Exception e)
            {
                Debug.WriteLine("");
                Debug.WriteLine(e.Message);
            }
        }


        public bool CheckSerialNr(string serialNr)
        {
            //YOUR CODE GOES HERE, MAKE ALL ASSERT TESTS PASS

            string pattern = @"[0-9]{2,3}[a-z]{3}[0-9]{2,3}$";
            Regex rgx = new Regex(pattern);
            MatchCollection matches = rgx.Matches(serialNr);

            if (matches.Count > 0)
            {
                Console.WriteLine($" {serialNr} = OK ");
                return true;
            }
            else
            {
                Console.WriteLine($" {serialNr} = EJ OK ");
                return false;
            }
        }



    }
}

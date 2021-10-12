using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ConsoleApp
{
    public class Test_05
    {
        //https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/operators/bitwise-and-shift-operators
        public Test_05()
        {
            //Räkna antalet unika objekt i slaskHinken

            List<Object> slaskHinken = new();
            slaskHinken.Add("överbliven text");
            slaskHinken.Add("oj oj, vad mycket text det har blivit över");
            slaskHinken.Add(23);
            slaskHinken.Add(23);
            slaskHinken.Add(new int());
            slaskHinken.Add(new int());
            slaskHinken.Add((Int64)(int.MaxValue) + 1);
            slaskHinken.Add((Int64)(int.MaxValue) - 1);
            slaskHinken.Add(new int[] { 1, 3, 5, 7, 9 });
            slaskHinken.Add(new int[] { 1, 3, 5, 7, 19 });

            UniqueItemsController(slaskHinken, 8, true, "Test_05 : Test1");
        }

        public void UniqueItemsController(List<Object> items, int uniqueItems, bool correctCount, string message)
        {
            try
            {
                Assert.AreEqual(ItemsController(items, uniqueItems), correctCount, message);
            }
            catch (Exception e)
            {
                Debug.WriteLine("");
                Debug.WriteLine(e.Message);
            }
        }

        public bool ItemsController(List<Object> items, int uniqueItems)
        {
            //YOUR CODE GOES HERE, MAKE ALL ASSERT TESTS PASS

            //Kan göras med generics och två loopar, eller med distinct

            int countedItems = items.Distinct().Count();

            if (countedItems == uniqueItems)
            {
                Console.WriteLine($"countedItems: {countedItems}. uniqueItems: {uniqueItems} = OK");
                return true;
            }
            else
            {
                Console.WriteLine($"countedItems: {countedItems}. uniqueItems: {uniqueItems} = EJ OK");
                return false;
            }
        }

    }
}

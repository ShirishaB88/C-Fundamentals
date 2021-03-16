 using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ReferenceTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void strings()
        {
            string name;
            string declared;
            declared = "This is intialized.";
            string declaredAndInitialize = "This is both declared and initialized";

            string firstName = "Shirisha";
            string lastName = "Bongu";
            string concatenatedFullName = firstName + " " + lastName;
            string interpolationFullName = $"{firstName} {lastName}";
            string compositeFullName = string.Format("{0} {1}", firstName, lastName);

            Console.WriteLine(firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(concatenatedFullName);
            Console.WriteLine(interpolationFullName);
            Console.WriteLine(compositeFullName);

        }
        [TestMethod]
        public void Collections()
        {
            string stringExample = "Hello World";
            string[] stringArray = { "Hello", "World", "Why", "is it", "always", stringExample };
           

            string thirdItem = stringArray[2]; //Arrays are Zero indexed, as its start with number 0
            Console.WriteLine(thirdItem);

            stringArray[0] = "Hey There";
            Console.WriteLine(stringArray[0]);
           
           
          
            // ctrl . creates new List/ queue
            List<string> listOfStrings = new List<string>();
            List<int> listOfInts = new List<int>();

            listOfStrings.Add("First string for our list");
            listOfInts.Add(123456);

            Console.WriteLine(listOfInts[0]);

            Queue<string> firstInFirstOut = new Queue<string>();
            
            firstInFirstOut.Enqueue("I'm First");
            firstInFirstOut.Enqueue("I'm next");

            string firstItem = firstInFirstOut.Dequeue();
            Console.WriteLine(firstItem);
            string secondItem = firstInFirstOut.Peek();

            Dictionary<int, string> keyAndValue = new Dictionary<int, string>();

            keyAndValue.Add(7, "Agent");
            
            string valueSeven = keyAndValue[7];
            Console.WriteLine(valueSeven);

            SortedList<int, string> sortedKeyandValue = new SortedList<int, string>();
            HashSet<int> uniqueList = new HashSet<int>();
            Stack<string> lastInFirstOut = new Stack<string>();
         }
        [TestMethod]
        public void Classes()
        {
            Random rng = new Random();

            int randomNumber = rng.Next();

            Console.WriteLine(randomNumber);
        }                    
    }
}

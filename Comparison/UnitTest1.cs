using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            //start with our variables
            int age = 25;
            string userName = "Terry";

            //check to see if something is = to something else

            bool equals = age == 41;
            Console.WriteLine(equals);

            bool userIsTerry = userName == "Terry";
            Console.WriteLine(userIsTerry);
            Console.WriteLine("user is 41: " + equals);

            // Using the Bang '!' Operator
            bool notEqual = age != 122;
            Console.WriteLine($"user is not 122: {notEqual}");

            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine(userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            //copmpare the List
            bool listareEqual = firstList == secondList;
            Console.WriteLine($"The List are equal?: {listareEqual}");

            //greater than
            bool greaterThan = age > 12;
            Console.WriteLine(greaterThan);

            //greater than or equal to
            bool greaterThanorEqual = age >= 24;
            Console.WriteLine(greaterThanorEqual);

            //lessThan 
            bool lessThan = age < 60;
            Console.WriteLine(lessThan);

            //less Than or Equal to
            bool lessThanOrEqualTo = age <= 24;
            Console.WriteLine(lessThanOrEqualTo);

            //we have the or '||'
            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = trueValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;


            Console.WriteLine($"True or True {tOrT}");
            Console.WriteLine($"True or False {tOrF}");
            Console.WriteLine($"False or True {fOrT}");
            Console.WriteLine($"False or False {fOrF}");

            // and '&&'
            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;

            Console.WriteLine($"True and True {tAndT}");
            Console.WriteLine($"True and False {tAndF}");
            Console.WriteLine($"False and True {fAndT}");
            Console.WriteLine($"False and False {fAndF}");



        }
    }
}

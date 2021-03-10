using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //addition '+'

            int sum = a + b;
            sum += 3; // This is short hand addition
            Console.WriteLine(sum);

            //substraction '-'
            int difference = a - b;

            Console.WriteLine($"difference:{difference}");

            //Multiplication '*'
            int product = a * b;

            Console.WriteLine($"product:{product}");

            //Division '/'

            int quotient = a / b;
            Console.WriteLine($"quotient:{quotient}");

            //modulous 
            int remainder = a % b;
            Console.WriteLine($"remainder:{remainder}");

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1988, 8, 28);

            TimeSpan timespan = now - someday;
            Console.WriteLine(timespan);
            Console.WriteLine(timespan.Days);
            Console.WriteLine(timespan.TotalMilliseconds);

            DateTime birthday = new DateTime(1988, 8, 28);
            DateTime someDay = new DateTime(2032, 8, 28);
            TimeSpan ageThen = someDay - birthday;
            
            DateTime toDay = DateTime.Now;
            DateTime oneDay = toDay.AddDays(30);
            Console.WriteLine(someDay);
            Console.WriteLine(ageThen);

        }
    }
}

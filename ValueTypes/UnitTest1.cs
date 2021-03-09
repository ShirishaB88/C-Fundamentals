using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ValueTypes
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Booleans()
        {
            bool isDeclared;
            isDeclared = true;

            bool  isDeclaredAndIntialized = false;

            isDeclaredAndIntialized = true;
        }

        [TestMethod]
        public void Characters()
        {
            char character = 'a';
            char symbols = '?';
            char numbers = '7';
            char space = ' ';
            char specialCharacters = '\n'; // '\n' represents new line.
        }
        [TestMethod]
        public void WholeNumbers()
        {
            byte byteExamples = 255;
            sbyte sByteExample = 127;
            short shortexample = 32767;
            Int16 anotherShortExample = 32000;
            int intMin = 2147483647;
            Int32 intMax = 2147483647;
            long longExample = 9223372036854775807;
            long longMin = -9223372036854775807;

            int a = 15;
            int b = -15;
            byte age = 25;

         }
        [TestMethod]
        public void Decimals()
        {
            float floatExample = 1.045231f;
            double doubleExample = 1.789053278907036d;
            decimal decimalExample = 1.2578907289045789789789789787897m;

            Console.WriteLine(floatExample);
            Console.WriteLine(doubleExample);
            Console.WriteLine(decimalExample);


        }
        enum Pastrytype { Cake, cupcake, Eclaire, Petitfour, Crossiant}
        [TestMethod]
        public void Enums()
        {
            Pastrytype myPastry = Pastrytype.Crossiant;
            Pastrytype anotherone = Pastrytype.Cake;
        }
        [TestMethod]
        public void Structs()
        {
            DateTime today = DateTime.Today;

            DateTime birthday = new DateTime(1988, 8, 28);

            Console.WriteLine(today);
        }
    }

}

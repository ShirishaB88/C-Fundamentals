using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Morning_Challenge
{
    [TestClass]
    public class conditionalAndLoop
    {
        string challenge = "Supercalifragilisticexpialidocious";
        [TestMethod]
        public void PrinteveryLetter()
        {
            foreach (char letter in challenge)
            {
                Console.WriteLine(letter);

            }


        }

        [TestMethod]
        public void step2()
        {
            foreach (char letter in challenge)
                if (letter == 'i')
            {
                Console.WriteLine("It's an i");
            }
            else
            {
                Console.WriteLine("It's not an i");
            }
        }

        [TestMethod]
        public void step3()
        {
            int lengthOfString = challenge.Length;
            Console.WriteLine("Number of Characters in string is :" + lengthOfString);

            Console.WriteLine(challenge.Length);
        }

        [TestMethod]
        public void PrintL()
        {
            foreach (char letter in challenge)
            {
                if(letter == 'l')
                {
                    Console.WriteLine('L');
                }
            }
        }
    }
}


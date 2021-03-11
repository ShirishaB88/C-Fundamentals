using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LoopExamples
{
    [TestClass]

    public class LoopTests

    {
        [TestMethod]
        public void WhileLoops()
        {
            //Just for setup

            int total = 1;

            //keep running as long as total isnt 10

            while (total != 10)
            {
                Console.WriteLine(total);

                total = total + 1;
            }

            total = 0;

            while (true)
            {
                if (total == 10)
                {
                    Console.WriteLine("Goal Reached");
                    break;
                }
                //we nee to increment up by 1 to escape the while loop
                total++;
            }

            // new set up
            Random random = new Random();

            int somecount;
            bool keepLooping = true;

            while (keepLooping)
            {
                // 0 inclusive , 20 exclusive so, its 19 (0-19)
                somecount = random.Next(0, 20);

                if (somecount == 6 || somecount == 10)
                {
                    continue;
                }

                Console.WriteLine(somecount);

                if (somecount == 15)
                {
                    keepLooping = false;
                }
            }



        }

        [TestMethod]
        public void ForLoops()
        {
            int studentCount = 21;

            // Instialization  conditional  increment

            for (int i = 0; i < studentCount;  i++)
            {
                Console.WriteLine(i);
            }

            string[] students = { "Adam", "justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            for (int i = 0;  i  < students.Length;   i++) 
            {
                Console.WriteLine($"Welcome to the class {students[i]}");
            }
        }
       
        
        [TestMethod]
        public void ForeachLoop()
        {
            string[] students = { "Adam", "justin", "Joshua", "Amanda", "Danielle", "Ingeborg" };

            foreach (string student in students)
            {
                Console.WriteLine(student + "is a student in the class");
            }

            //string is an array of char
            string Myname = " shirisha Bongu";
            foreach (char letter in Myname)

            {
                if (letter != ' ')
                {
                    Console.WriteLine(letter);
                }
                
            }
        }

        [TestMethod]
        public void DoWhileLoops()
        {
            int interator = 0;
            do
            {
                Console.WriteLine("Hello");
                interator++;

            } while (interator < 5);
            do
            {
                Console.WriteLine("My do while condition is false");
            } while (false);

            while (false)
            {
                // linter is telliong that code is unreachable
                Console.WriteLine("My while condition is false");
            }
        }
    }
}


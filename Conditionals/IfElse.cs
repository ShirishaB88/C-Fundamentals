using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Conditionals
{
    [TestClass]
    public class IfElse
    {
        [TestMethod]
        public void IfStatements()
        {
            bool userIsHungry = true;
            if (userIsHungry)
            {
                Console.WriteLine("Eat Something!");
            }

            int hoursSpentstudying = 1;
            if (hoursSpentstudying < 16)
            {
                Console.WriteLine("are you even trying");
            }
        }
        [TestMethod]
        public void IfElseStatments()
        {
            bool choresareDone = false;
            if (choresareDone)
            {
                Console.WriteLine("Haave fun at the Movies!");

            }
            else
            {
                Console.WriteLine("You must stay home and finish CHORES!");
            }

            string input = "2";
            int totalHours = int.Parse(input);

            if(totalHours>=8)
            {
                Console.WriteLine( "You should be well rested");
            }
            else
            {
                Console.WriteLine("You might be tired today");
                if(totalHours < 4)
                {
                    Console.WriteLine("You should get more slepp!");
                }
            }

            int age = 32;
            if (age > 17)
            {
                Console.WriteLine("You are an adult");
            }
            else
            {
                if(age > 6)
                {
                    Console.WriteLine("You are a kid!");
                }
                else if(age > 0)
                {
                    Console.WriteLine("you are far to young to be on a computer");
                }
                else
                {
                    Console.WriteLine("you are not born yet");
                }
            }

            if (age <65 && age > 18)
            {
                Console.WriteLine("Age is between 18 and 65");
            }

            if (age  >65 || age < 18)
            {
                Console.WriteLine("age is either greater than 65 or less than 18");
            }
            if(age == 21)
            {
                Console.WriteLine("Age is equal to 21");
            }
            if(age != 36)
            {
                Console.WriteLine("Age is not eual to 36");
            }
        }
    }
}

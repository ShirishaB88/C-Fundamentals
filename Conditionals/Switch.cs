using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conditionals
{
    [TestClass]
    public class Switch
    {
        enum weekDay { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }
        [TestMethod]
        public void SwitchCases()
        {
            int input = 1;
            switch (input)
            {
                case 1:
                    Console.WriteLine("Hello");

                    break;

                case 2:
                    Console.WriteLine("What are you doing");
                    break;

                default:
                    Console.WriteLine("This is a deafault: it will execute if no case is met");
                    break;
            }

            weekDay today = weekDay.Wednesday;

            switch (today)
            {
                case weekDay.Monday:
                case weekDay.Tuesday:
                case weekDay.Wednesday:
                case weekDay.Thursday:
                case weekDay.Friday:
                    Console.WriteLine("Hope you are ready to work!!");
                    break;
                case weekDay.Saturday:
                case weekDay.Sunday:
                    Console.WriteLine("Sorry. we are closed!");
                    break;
            }

            int age = 37;
            switch (age)
            {
                case 18:
                    break;
                case 19:
                    break;
                case 20:
                    break;
                case 21:
                    break;
                case 22:
                    break;
                default:
                    break;

            }


        }

      
    }
}

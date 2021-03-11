using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}");
        }
        public void Hello()
        {
            Console.WriteLine("Hello");
        }
        Random _random = new Random(); // underscore is to private

        public void getRandomGreeter()
        {
            string[] availableGreetings = new string[] { "Good Morning", "Whats up", "Whats up dawg", "Howdy" }; //creating string array , have 4 number of strings
            int randomNumber = _random.Next(0, 4); //0 is inclusive and 4 is exclusive we are exclusing 4 and only read 0,1,2,3
                                                   //.Next brings up random any numbers we specify

            string randomGreeting = availableGreetings.ElementAt(randomNumber);// the ElementAt calls specified position in source sequence
            Console.WriteLine($"{randomGreeting}");
        }

    }
}

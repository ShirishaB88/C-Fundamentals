using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceClasses
{
    public class Cats : Animals //InHerited the properties of Animals like IsMammal and Diet type
    {
        public Cats()
        {
            Console.WriteLine("This is a cat constructor");
            IsMammal = true;
            DietType = DietType.Carnivore;
        }
        public bool IsEvil  { get; set; }
        public int HowManyWhiskers { get; set; }
        public string Color { get; set; }
        public string HairLength { get; set; }

        public virtual void Makesound()
        {
            Console.WriteLine("Moew");
        }
        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly."); //GetType --gets the type of current instance
        }
    }

    public class Liger : Cats
    {
        public Liger() //ctor tab tab for constructor
        {
            Console.WriteLine("This is the Liger constructor");
        }

        public override void Move()
        {
            Console.WriteLine($"{GetType().Name} stalks it's pray.");
        }

        public override void Makesound()
        {
            Console.WriteLine("Roar");
        }

    }

    public class Lion : Cats
    {
        public Lion()
        {
            Console.WriteLine("This is a Lion constructor");
        }

        public override void Makesound()
        {
            Console.WriteLine("Twinkle Toes");        
        }

    }

}

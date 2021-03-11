using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace InheritanceClasses //enum gives specific index numbers to the list --Indexing Things
{
    public enum DietType { Herbivore = 1, Omnivore, Carnivore} //changed the index to 1 default it will be zero. (We can give specific index number to specific string)
    public class Animals
    {
        public Animals()
        {
            Console.WriteLine("This is a animal consructor");
        }

        public string AnimalName { get; set; }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool Hasfur { get; set; }
        public DietType DietType { get; set; }

        public virtual void Move() //virtual allows the specific method to be over  written
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }

    }
}

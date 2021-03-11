using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Classes
{

    public class Person
    {
        public string FullName  //getting the properties inside get
        {
            get
            {
                return $"{ FirstName} { LastName}";
            }
        }
        public string FirstName { get; set; }

        private string _lastName;

        public string LastName
        {
            get { return  _lastName; }
            set { _lastName = value; }
        }
        public DateTime DateOfBirth { get; set; }

        public int age //int is the return value -----get the int number as a result-------on line 34
        {                               
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth; //TimeSpan is used for difference between dates returs ind days
                double totalAgeInYears = ageSpan.TotalDays / 365.25;
                int yearsOfAge = Convert.ToInt32(Math.Floor(totalAgeInYears)); //convert.Toint32 coverts the num to int of 32 bytes
                return yearsOfAge;                                                                                    //Math.Floor rounds down the number
                                                                                                                         
            }
                
        }

        public Vehicle Transport { get; set; }

        public Person() { }

        public Person (string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }
        
    }
}

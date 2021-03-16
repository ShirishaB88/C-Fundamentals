using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morning_Challenge
{

    public class User //Give the user a FirstName, LastName, ID (an integer, with no setter), and BirthDate properties.
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int ID { get; } //no set means that is not  changable by user basically used for unique Identification Number.
        public DateTime BirthDate { get; set; }

        public User() { } //Create a blank constructor 

        public User(string firstname, string lastname, int idNumber, DateTime dateOfBirth) //a full constructor for this class.
        {
            FirstName = firstname;
            LastName = lastname;
            ID = idNumber;
            BirthDate = dateOfBirth;

        }

        public string FullName //Create a method that returns the full name of the user.
        {
            get
            {
                return $"{ FirstName} { LastName}";
            }
        }

        public DateTime DateOfBirth { get; set; } //Create a method that returns the age of the user in years.
        public int Age
        {
            get
            {
                TimeSpan ageSpan = DateTime.Now - DateOfBirth;
                double yearsOfage = ageSpan.TotalDays / 365.25;
                int ageInYears = Convert.ToInt32(Math.Floor(yearsOfage));
                return ageInYears;

            }


        }
        
    }

}













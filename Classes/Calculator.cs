using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
   public class Calculator
    {
        //Access modifier(public) int (return  type) Add (method signature) then parameters in ()------In  Method
        public int Add(int numOne,  int numTwo)
        {
            int sum = numOne + numTwo;  //sum is a operator
            return sum;     //If we do not need a return type use void in method Ex:public void Add()
        }

        public double Add(double numOne, double numTwo)
        {
            double sum = numOne + numTwo;
            return sum;
        }

        public int  CalculateAge(DateTime birthdate)
        {
            TimeSpan ageSpan = DateTime.Now - birthdate;
            double totalAgeYears = ageSpan.TotalDays / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeYears)); //floor is used to round the number down
            return years; // int will return as we gave return type as int
        }
    }
}

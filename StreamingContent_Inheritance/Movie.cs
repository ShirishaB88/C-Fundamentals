using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class Movie:StreamingContent
    {
        //We Get All Of the properties From a streaming Content B/c a Movie is "StreamingContent"
        public double RunTime { get; set; }
        public Movie()
        {

        }

        public Movie(string title, string description, MaturityRating maturityRating, GenereType genereType, double starRating, double runTime)
                     :base(title,description,maturityRating,genereType,starRating)
        {
            RunTime = runTime;
        }
    }
}

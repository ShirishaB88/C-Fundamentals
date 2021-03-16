using RepositoryPatterns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamingContent_Inheritance
{
    public class StreamingRepository : StreamingContentRepository
    {    //We Weill use the same _contentDirectory from streamingcontentRepository.cs
        //read
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content.GetType() == typeof(Show))
                {
                    return (Show)content;
                }
            }
            return null;
        }

        //Read Movie

        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower() && content is Movie)
                {
                    return (Movie)content;
                }
            }
            return null;
        }

        //Read get all
        public List<Show> GetAllShows()
        { //use this to add our shows ---> this is a newed up version of the list (we will return this list
            List<Show> allshows = new List<Show>();
            foreach (StreamingContent content in _contentDirectory)
            {
                //if the content that we find is of type show 
                if (content is Show)
                {
                    //add the show to the allshow list
                    allshows.Add((Show)content);
                }
            }
            return allshows;

        }

        ////Read get all the movies
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();

            foreach (StreamingContent content in _contentDirectory)
            {
                if (content is Movie)
                {
                    allMovies.Add(content as Movie);
                }

            }
            return allMovies;
        }

    }
}
//Challenges 
//Get by Runtime/AverageTime
//Get Shows with over X episodes
//Get Shows/Movie By Rating
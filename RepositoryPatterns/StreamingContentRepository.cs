using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryPatterns
{
   public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        //create
        public bool AddContentToDirectory(StreamingContent content) //looking for wether content was added or not to streamingContent
        {
            int startingCount = _contentDirectory.Count; //creating variable starting count 

            _contentDirectory.Add(content);     //content added to the new list called _contentDirectory

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true: false; //bool if content added comes true or false
            return wasAdded;
        }
        //read
        public List<StreamingContent> GetContent()
        {
            return _contentDirectory;
        }

        //getting content by the title
        //read --> healper method b/c used through out this repo
        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.Title.ToLower() == title.ToLower())   //lowering the variable title
                {
                    return content;
                }
            }
            return null;
        }

        //getting content by the description
        public StreamingContent GetContentByDescription(string description)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                  if (content.Description.ToLower() == description.ToLower())
                  {
                    return content;
                  }
                
            }

            return null;
        }

        //getting content by the genre type
        
        public StreamingContent GetContentByGenreType(GenereType genereType)
        {
            List<StreamingContent> listOfContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.GenreType == genereType)
                {
                    listOfContent.Add(content); 
                    return content;
                }
               
            }

            return null;
        }

        //getting content by the Starrating
        public StreamingContent GetContentByStarRating(double starRating)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if (content.StarRating == starRating)
                {
                    return content;
                }
            }
            return null;
        }

        //getting the content by the isfamilyfriendly
         public StreamingContent GetContentByIsFamilyFriendly(bool isFamilyFriendly)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.isFamilyFriendly== isFamilyFriendly)
                {
                    return content;
                }
            }
            return null;
        } 
        
        //getting content by maturity rating

        public StreamingContent GetContentBymaturityrating (MaturityRating maturityRating)
        {
            List<StreamingContent> listOfContent = new List<StreamingContent>();
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.MaturityRating == maturityRating)
                {
                    listOfContent.Add(content);
                    return content;
                }
            }
            return null;
        }
         
        //update
        public bool UpdateExisitingContent(string originaltitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originaltitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.MaturityRating = newContent.MaturityRating;
                oldContent.GenreType = newContent.GenreType;
                oldContent.StarRating = newContent.StarRating;

                return true;
            }
            else
            {
                return false;
            }
        }
        //delete
        public bool DeleteExisitingContent(StreamingContent exisitingContent)
        {
            bool deleteResult = _contentDirectory.Remove(exisitingContent);
            return deleteResult;
        }
    } 
    
    
    // get by other parameters
    //get by rating
    //get by familyfriendly
}

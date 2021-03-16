using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepositoryPatterns;
using System;
using System.Collections.Generic;

namespace StreamingContentRepositoryTest
{
    [TestClass]
    public class UnitTest1
    {
        //so we want to The add method in the repo
        [TestMethod]
        public void AddToDirectory_ShouldgetCorrectBoolean()
        {
            //AAA -> Arrange, Act, assert
            
            //arrange-> overall setup
            //Create The content
            StreamingContent content = new StreamingContent();
            StreamingContentRepository repository = new StreamingContentRepository();

            //Act -> Get/run the code to test
            bool addresult = repository.AddContentToDirectory(content);

            //Assert --> Use to get the expect outcome of a test
            Assert.IsTrue(addresult);

        }

        //testing the read Method
        [TestMethod ]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            //AAA Rules Apply 

            //Arrange --> intitial setup
            //creating the content
            StreamingContent content = new StreamingContent();

            //creating the repo
            StreamingContentRepository repo = new StreamingContentRepository();

            //Adding to the repo
            repo.AddContentToDirectory(content);

            //Act
            //our plan is to store the list of streaming content w/n a variable 
           List<StreamingContent> listOfMovies = repo.GetContent();

            //looks threw our entire list and returns true if there is content
            bool directoryHasContent = listOfMovies.Contains(content);

            //Asssert
            Assert.IsTrue(directoryHasContent);
        }

        //We will start with private "fields'

        private StreamingContentRepository _repo;
        private StreamingContent _contents;


        //this Is The Arrange Part
        [TestInitialize]

        public void Arrange()
        {     //make a movie 
            _repo = new StreamingContentRepository();

            //add
            _contents = new StreamingContent("Rubber", "A Car tyre come to life eith the power to make people explode",
                MaturityRating.R,GenereType.Drama, 5.8d);

            //now addthe movie is in our database()list
            _repo.AddContentToDirectory(_contents);
        }

        //retrive content by title
        [TestMethod]
        public void GetByTitle_ShouldReturnCorrectContent()
        {
            //Arrange ...Already done above

            //Act
            StreamingContent searchResult = _repo.GetContentByTitle("Rubber");

            //Assert
            Assert.AreEqual(_contents, searchResult);
        }

        [TestMethod]
        public void UpdateExistingContent_ShouldReturnTrue()
        {
            //arrange -> Updated version of our movie 
            StreamingContent newcontent = new StreamingContent("Rubber part2", "A Car tyre come to life eith the power" +
                " to make people explode", MaturityRating.R, GenereType.Drama, 9.8d);

            //Act
            bool updateResult = _repo.UpdateExisitingContent("Rubber", newcontent);

            //Assert
            Assert.IsTrue(updateResult);
            //Console.WriteLine(GiveMeTheInfo(_content));
        }

        //public string GiveMeInfo(StreamingContent content)
        //{
        //  var result = $"(content.Title)\n" + $"(content.starrating)";
        //   return result;
        //}


        //Test the delete Method 
        [TestMethod]
        public void DeleteExisitingContenst_ShouldReturnTrue()
        {
            //Arrange
            StreamingContent content = _repo.GetContentByTitle("Rubber");

            //Act
            bool removeResult = _repo.DeleteExisitingContent(content);

            //Assert
            Assert.IsTrue(removeResult);
        }
    }
}

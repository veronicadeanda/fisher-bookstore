using System;
using Fisher.Bookstore.Api.Models;
using Xunit;

namespace tests
{
    public class AuthorTest
    {
        [Fact] 
        public void ChangeBio()
        {
            //Arrange
            var author = new Author()
            {
                Id = 1,
                Name = "Jon Doe",
                Bio = "Born in 1999"
            };

            //Act
            var newBio = "Born in 1980 in Cleveland, OH";
            author.ChangeBio(newBio);

            //Assert
            var expectedBio = newBio;
            var actualBio = author.Bio;

            Assert.Equal(expectedBio, actualBio);
        }
    }
}
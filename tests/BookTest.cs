using System;
using Fisher.Bookstore.Api.Models;
using Xunit;

namespace tests
{
    public class BookTest
    {
        [Fact] 
        public void ChangePublicationDate()
        {
            //Arrange
            var book = new Book()
            {
                Id = 1, 
                Title = "Domain Driven Design",
                Author = new Author()
                {
                    Id = 65,
                    Name = "Eric Evans" 
                },
                PublishDate = DateTime.Now.AddMonths(-6),
                Publisher = "McGraw-Hill"
            };

            //Act
            var newPublicationDate = DateTime.Now.AddMonths(2);
            book.ChangePublicationDate(newPublicationDate);

            //Assert
            var expectedPublicationDate = newPublicationDate.ToShortDateString();
            var actualPublicationDate = book.PublishDate.ToShortDateString();
            
            Assert.Equal(expectedPublicationDate, actualPublicationDate);

        }
    
        [Fact]
        public void ChangePublisher()
        {
            //Arrange
            var book = new Book()
            {
                Id = 2,
                Title = "ABC",
                Author = new Author()
                {
                    Id = 66,
                    Name = "John Smith"
                },
                PublishDate = DateTime.Now,
                Publisher = "McGraw-Hill"
            };

            //Act
            var newPublisher = "Scholastic";
            book.ChangePublisher(newPublisher);

            //Assert
            var expectedPublisher = newPublisher;
            var actualPublisher = book.Publisher;

            Assert.Equal(expectedPublisher, actualPublisher);
        }
    }
}

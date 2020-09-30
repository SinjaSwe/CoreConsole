using System;
using System.Security.Cryptography.X509Certificates;
using Xunit;
 

namespace CoreConsole.Model.Tests
{
    public class CoreConsoleModelTests
    {
        [Fact]
        public void PersonConstructor()
        {
            //Arrange
            string firstname = "Jane";
            string lastname = "Doe";

            //Act
            Person result = new Person(firstname, lastname);

            //Assert
            Assert.NotNull(result);
            Assert.Contains(firstname, result.PersonInformation());
            Assert.Contains(lastname, result.PersonInformation());
        }


        [Theory]// replace Fact to test with many alternate values that are bad.
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        //[InlineData(" test to fail ")]

        public void EmptyCellConstructorPersonFn(string firstname)
        {
            //Arrange
            string lastname = "Doe";
            Person person = new Person(firstname, lastname);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => person.Firstname = firstname);                    

        }

        [Theory]// replace Fact to test with many alternate values that are bad.
        [InlineData(null)]
        [InlineData("")]
        [InlineData(" ")]
        //[InlineData(" test to fail ")]
        public void EmptyCellConstructorPersonLn(string lastname)
        {
            //Arrange
            string firstname = "Jane";
            Person person = new Person(firstname, lastname);

            //Act & Assert
            Assert.Throws<ArgumentException>(() => person.Lastname = lastname);
        }

        //field small letter color
        //property big letter Color
    }
}

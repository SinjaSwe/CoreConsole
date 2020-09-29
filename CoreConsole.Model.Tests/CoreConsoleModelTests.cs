using System;
using Xunit;

namespace CoreConsole.Model.Tests
{
    public class CoreConsoleModelTests
    {
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
    }
}

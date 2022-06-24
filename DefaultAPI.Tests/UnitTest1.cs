using DefaultAPI.Controllers;
using Microsoft.AspNetCore.Mvc;

namespace DefaultAPI.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
            ValuesController _controller = new();

            //Act
            IActionResult actual = _controller.Get();

            //Assert
            Assert.IsType<OkResult>(actual);
        }
    }
}
using SimpleMvcApp.Controllers;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace SimpleMvcApp.Tests
{
    public class HelloControllerTests
    {
        [Fact]
        public void Index_ReturnsContentResult_WithHelloWorldMessage()
        {
            // Arrange
            var controller = new HelloController();

            // Act
            var result = controller.Index();

            // Assert
            var contentResult = Assert.IsType<ContentResult>(result);
            Assert.Equal("Hello, World!", contentResult.Content);
        }
    }
}

using Xunit;
using App.Controllers;

namespace App.Tests
{
    public class RootControllerTests
    {
        [Fact]
        public void HelloWorld()
        {
            var controller = new RootController();
            string expected = "Hello, World!";
            string actual = controller.Get();
            Assert.Equal(expected, actual);
        }
    }
}

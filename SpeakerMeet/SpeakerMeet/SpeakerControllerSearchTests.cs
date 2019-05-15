using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpeakerMeet
{
    [TestClass]
    public class SpeakerControllerSearchTests
    {
        [TestMethod]
        public void ItHasSearch()
        {
            var controller = new SpeakerController();
            var result = controller.Search("Jos");
            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(OkObjectResult));
        }
    }
}

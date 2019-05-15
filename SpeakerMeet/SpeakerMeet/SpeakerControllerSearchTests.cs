using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SpeakerMeet
{
    [TestClass]
    public class SpeakerControllerSearchTests
    {
        private SpeakerController controller;
        [TestInitialize]
        public void Setup()
        {
            controller = new SpeakerController();
        }
        [TestMethod]
        public void ItHasSearch()
        {
            var result = controller.Search("Jos");
            result.Should().NotBeNull();
            result.Should().BeOfType(typeof(OkObjectResult));
        }

        [TestMethod]
        public void ItReturnsCollectionOfSpeakers()
        {
            var result = controller.Search("Jos") as OkObjectResult;
            result.Should().NotBeNull();
            result.Value.Should().NotBeNull();
            result.Value.Should().BeOfType(typeof(List<Speaker>));
        }

        [TestMethod]
        public void GivenExactMatchThenOneSpeakerInCollection()
        {
            var result = controller.Search("Joshua") as OkObjectResult;
            var speakers = ((IEnumerable<Speaker>)result.Value).ToList();
            speakers.Count.Should().Be(1);
        }
    }
}

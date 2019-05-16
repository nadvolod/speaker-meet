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
            Assert.AreEqual("Joshua", speakers[0].Name);
        }
        [DataTestMethod]
        [DataRow("Joshua")]
        [DataRow("joShua")]
        [DataRow("joShuA")]
        public void GivenCaseInsensitiveMatchThenSpeakerInCollection(string searchString)
        {
            var result = controller.Search(searchString) as OkObjectResult;
            var speakers = ((IEnumerable<Speaker>)result.Value).ToList();
            speakers.Count.Should().Be(1, $"we expect that the string isn't case sensitive=>{searchString}");
            speakers[0].Name.Should().Be("Joshua", $"we expect that the string isn't case sensitive=>{searchString}");
        }

        public void GiventNoMatchThenEmptyCollection()
        {
            var result = controller.Search("BADSTRING") as OkObjectResult;
            var speakers = ((IEnumerable<Speaker>)result.Value).ToList();
            speakers.Count.Should().Be(0, "we provided an invalid search string");
        }
    }
}

using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpeakerMeet.API.Tests
{
    [TestClass]
    public class SpeakerServiceTests
    {
        private object _fakeRepository;

        [TestMethod]
        public void ItTakesGravatarService()
        {
            var fakeGravatarService = new FakeGravatarService();
            var service = new SpeakerService(_fakeRepository, fakeGravatarService);
        }
        [TestMethod]
        public void ItCallsGravatarService()
        {
            var expectedSpeaker = 
            var fakeGravatarService = new FakeGravatarService();
            var service = new SpeakerService(_fakeRepository, fakeGravatarService);
        }
    }
}

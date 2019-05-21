using FluentAssertions;
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

        public SpeakerFactory SpeakerFactory { get; private set; }

        [TestInitialize]
        public void Setup()
        {
            SpeakerFactory = new SpeakerFactory();
        }

        [TestMethod]
        public void ItTakesGravatarService()
        {
            var fakeGravatarService = new FakeGravatarService();
            var service = new SpeakerService(_fakeRepository, fakeGravatarService);
        }
        [TestMethod]
        public void ItCallsGravatarService()
        {
            var expectedSpeaker = SpeakerFactory.Create(_fakeRepository);
            var fakeGravatarService = new FakeGravatarService();
            var service = new SpeakerService(_fakeRepository, fakeGravatarService);

            var speaker = service.Get(service.Id);
            fakeGravatarService.GetGravatarCalled.Should().BeTrue();
        }
    }
}

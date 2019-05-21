using System;

namespace SpeakerMeet.API.Tests
{
    internal class SpeakerService
    {
        private object _fakeRepository;
        private IGravatarService fakeGravatarService;

        public SpeakerService(object fakeRepository, IGravatarService fakeGravatarService)
        {
            _fakeRepository = fakeRepository;
            this.fakeGravatarService = fakeGravatarService;
        }

        public object Id { get; internal set; }

        internal object Get(object id)
        {
            throw new NotImplementedException();
        }
    }
}
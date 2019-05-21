using System;

namespace SpeakerMeet.API
{
    public class FakeGravatarService : IGravatarService
    {
        public FakeGravatarService()
        {
        }

        public bool GetGravatarCalled { get; set; }
    }
}
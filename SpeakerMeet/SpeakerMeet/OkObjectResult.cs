using System.Collections.Generic;

namespace SpeakerMeet
{
    internal class OkObjectResult
    {
        public List<Speaker> Value => ReturnSpeakers();

        private List<Speaker> ReturnSpeakers()
        {
            var list = new List<Speaker>
            {
                new Speaker("Joshua")
            };
            return list;
        }
    }
}
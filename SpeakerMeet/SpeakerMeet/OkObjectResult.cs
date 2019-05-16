using System.Collections.Generic;

namespace SpeakerMeet
{
    internal class OkObjectResult
    {
        private readonly string searchedName;

        public OkObjectResult(string searchString)
        {
            this.searchedName = searchString;
        }

        public List<Speaker> Value => ReturnSpeakers();

        private List<Speaker> ReturnSpeakers()
        {
            var currentSpeakers = new List<Speaker>
            {
                new Speaker("Joshua")
            };

            var matchingSpeakers = new List<Speaker>();
            foreach (var speaker in currentSpeakers)
            {
                if(speaker.Name.ToLower() == searchedName.ToLower())
                {
                    matchingSpeakers.Add(speaker);
                }
            }
            return matchingSpeakers;
        }
    }
}
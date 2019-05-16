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
                new Speaker("Joshua"),
                new Speaker("Joseph"),
                new Speaker("Josh")
            };

            var matchingSpeakers = new List<Speaker>();
            foreach (var speaker in currentSpeakers)
            {
                if(speaker.Name.StartsWith(searchedName.ToLower(), System.StringComparison.OrdinalIgnoreCase))
                {
                    matchingSpeakers.Add(speaker);
                }
            }
            return matchingSpeakers;
        }
    }
}
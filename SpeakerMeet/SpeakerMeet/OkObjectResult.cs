using System.Collections.Generic;

namespace SpeakerMeet
{
    internal class OkObjectResult
    {
        private string name;

        public OkObjectResult(string searchString)
        {
            this.name = searchString;
        }

        public List<Speaker> Value => ReturnSpeakers();

        private List<Speaker> ReturnSpeakers()
        {
            var list = new List<Speaker>
            {
                new Speaker("Joshua")
            };

            var matchingSpeakers = new List<Speaker>();
            foreach (var speaker in list)
            {
                if(speaker.Name.ToLower() == name.ToLower())
                {
                    matchingSpeakers.Add(speaker);
                }
            }
            return matchingSpeakers;
        }
    }
}
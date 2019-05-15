namespace SpeakerMeet
{
    internal class Speaker
    {
        public Speaker(string name)
        {
            this.Name = name;
        }
        //This is the same as having another property called _name
        //and then retrieving that property like this public string Name => _name;
        public string Name { get; }
    }
}
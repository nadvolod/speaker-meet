namespace SpeakerMeet
{
    internal class Speaker
    {
        private string _name;

        public Speaker(string name)
        {
            this._name = name;
        }

        public string Name => _name;
    }
}
using System.Collections.Generic;

namespace BigRacing
{
    class Teem
    {
        public List<Participant> Parts { get; set; }
        public string Name { get; set; }
        public Teem(string name, List<Participant> participants)
        {
            Parts = participants;
            Name = name;
        }
    }
}

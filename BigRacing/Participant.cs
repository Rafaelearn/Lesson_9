using System;

namespace BigRacing
{
    class Participant :Human
    {
        private byte power;
        public byte Power
        {
            get { return power; }
            set 
            {
                if (value == 0 || value > 10)
                {
                    throw new FormatException("power is not {1; 10}");
                }
                power = value; 
            }
        }
        private byte intelligence;
        public byte Intelligence
        {
            get { return intelligence; }
            set
            {
                if (value == 0 || value > 10)
                {
                    throw new FormatException("intelligence is not {1; 10}");
                }
                intelligence = value;
            }
        }
        private byte dexterirty;
        public byte Dexterirty
        {
            get { return dexterirty; }
            set 
            {
                if (value == 0 || value > 10)
                {
                    throw new FormatException("dexterirty is not {1; 10}");
                }
                dexterirty = value; 
            }
        }

        public Participant(string name, byte power, byte dexterirty, byte intelligence) : base(name)
        {
            Power = power;
            Dexterirty = dexterirty;
            Intelligence = intelligence;
        }
        public Participant()
        {

        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Power: {Power}");
            Console.WriteLine($"Dexterirty: {Dexterirty}");
            Console.WriteLine($"Intelligence: {Intelligence}");
        }

    }
}

using System;
using System.Linq;

namespace BigRacing
{
    class Organizer :Human
    {
        public ulong PhoneNumber { get; private set; }
        private string email;
        public string Email
        {
            get { return email; }
            private set
            {
                if (value.Contains(' ') || !value.Contains('@'))
                {
                    throw new FormatException($"Owner {Name} have wrong format email-string");
                }
                email = value;
            }
        }
        public Organizer(string name, ulong phoneNumber, string email) :base(name)
        {
            PhoneNumber = phoneNumber;
            Email = email;
        }
        public override void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone Number: {PhoneNumber}");
        }
    }
}

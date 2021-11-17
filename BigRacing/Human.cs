namespace BigRacing
{
    abstract class Human
    {
        public string Name { get; set; }
        public Human(string name)
        {
            Name = name;
        }
        public Human()
        {

        }
        abstract public void Display();
    }
}

namespace Lab_9
{
    abstract class Figure
    {
        public Colour Colour { get; set; } = Colour.White;
        public bool Condition { get; set; } = true;

        abstract public void MoveHorz(double delta);
        abstract public void MoveVert(double delta);
        abstract public void Display();
    }
}

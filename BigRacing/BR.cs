using System.Collections.Generic;
using System;
namespace BigRacing
{
    class BR
    {

        public  List<Teem> Teems { get; set; }
        public Organizer Organizer { get; private set; }
        public string Name { get; private set; }
        public string Discription { get; private set; }
        public BR(string name, Organizer organizer, string discription)
        {
            Name = name;
            Discription = discription;
            Organizer = organizer;
        }
        public void PlayGame(IGame game)
        {
            game.StartGame(Teems);
        }
        public void DisplayWinner()
        {
            Teem winner = new Teem();
            foreach (var item in Teems)
            {
                double maxPoint = 0;
                if(maxPoint < item.NumberPoint)
                {
                    winner = item;
                }
            }
           Console.WriteLine($"Победитель больших гонок: {winner.Name}");
           Console.WriteLine($"Количество набранных очков: {winner.NumberPoint}");
        }
    }
}

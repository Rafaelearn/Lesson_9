using System;
using System.Collections.Generic;
namespace BigRacing
{
    class Slide : IGame
    {
        public void StartGame(List<Teem> Teems)
        {
            Console.WriteLine("Горка");
            for (int i = 0; i < Teems.Count; i++)
            {
                for (int j = 0; j < Teems[i].Parts.Count; j++)
                {
                    Teems[i].AddPoint(Teems[i].Parts[j].Power);
                }
            }
        }
    }
}

using System;
using System.Collections.Generic;
namespace BigRacing
{
    class MyGame :IGame
    {
        public void StartGame(List<Teem> Teems)
        {
            Console.WriteLine("Викторина про Марианскую Впадину");
            for (int i = 0; i < Teems.Count; i++)
            {
                for (int j = 0; j < Teems[i].Parts.Count; j++)
                {
                    Teems[i].AddPoint(Teems[i].Parts[j].Intelligence);
                }
            }
        }
    }
}

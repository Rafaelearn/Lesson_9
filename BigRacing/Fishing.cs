using System;
using System.Collections.Generic;
namespace BigRacing
{
    class Fishing : IGame
    {
        public void StartGame(List<Teem> Teems)
        {
            Console.WriteLine("Рыбалка");
            for (int i = 0; i < Teems.Count; i++)
            {
                for (int j = 0; j < Teems[i].Parts.Count; j++)
                {
                    Teems[i].AddPoint(Teems[i].Parts[j].Dexterirty * 0.5 + Teems[i].Parts[j].Intelligence * 0.5);
                }
            }
        }
    }
}

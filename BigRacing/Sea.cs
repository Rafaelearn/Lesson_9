using System;
using System.Collections.Generic;
namespace BigRacing
{
    class Sea : IGame
    {
        public void StartGame(List<Teem> Teems)
        {
            Console.WriteLine("Море");
            for (int i = 0; i < Teems.Count; i++)
            {
                for (int j = 0; j < Teems[i].Parts.Count; j++)
                {
                    Teems[i].AddPoint(Teems[i].Parts[j].Dexterirty * 0.8 + Teems[i].Parts[j].Power * 0.2);
                }
            }
        }
    }
}

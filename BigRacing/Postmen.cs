using System;
using System.Collections.Generic;
namespace BigRacing
{
    class Postmen : IGame
    {
        public void StartGame(List<Teem> Teems)
        {
            Console.WriteLine("Почтальон");
            for (int i = 0; i < Teems.Count; i++)
            {
                for (int j = 0; j < Teems[i].Parts.Count; j++)
                {
                    Teems[i].AddPoint(Teems[i].Parts[j].Dexterirty * 0.3 + Teems[i].Parts[j].Intelligence * 0.7);
                }
            }
        }
    }
}

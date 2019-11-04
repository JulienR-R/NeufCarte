using System;
using System.Collections.Generic;
using System.Linq;

namespace NeufCarte.model
{
    public interface IPaquet
    {
        List<ICarte> ListCartes { get; set; }

        ICarte DistribuerCarte();

        void BrasserPaquet();
    }

    public class Paquet : IPaquet
    {
        public List<ICarte> ListCartes { get; set; }

        private Random rand;

        public Paquet()
        {
            ListCartes = new List<ICarte>();
            rand = new Random();
            RemplirPaquet();
        }

        private void RemplirPaquet()
        {
            foreach (Couleur couleur in Enum.GetValues(typeof(Couleur)))
            {
                foreach (Valeur valeur in Enum.GetValues(typeof(Valeur)))
                {
                    ICarte c = new Carte(valeur, couleur);
                    ListCartes.Add(c);
                }
            }
        }

        public ICarte DistribuerCarte()
        {
            int randint = rand.Next(0, ListCartes.Count);
            ICarte resultat = ListCartes.ElementAt(randint);
            ListCartes.RemoveAt(randint);
            return resultat;
        }

        public void BrasserPaquet()
        {
            for (int i = 0; i < 100; i++)
            {
                int min = 0, max = ListCartes.Count;
                int pos1 = rand.Next(min, max);
                ICarte c1 = ListCartes.ElementAt(pos1);
                int pos2 = rand.Next(min, max);
                ICarte c2 = ListCartes.ElementAt(pos2);
                ICarte tempon = c1;
                ListCartes[pos1] = c2;
                ListCartes[pos2] = tempon;
            }
        }
    }
}
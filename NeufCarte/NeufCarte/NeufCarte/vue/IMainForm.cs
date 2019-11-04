using NeufCarte.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeufCarte.vue
{
    interface IMainForm
    {
        //Afficher le message d'aide.
        Action<object, EventArgs> AffAide { get; set; }

        //Ajouter les cartes du joueur dans la listBox.
        event EventHandler Load;
        //void AddCards(Paquet paquet);
        void AddCards(List<ICarte> main);
    }
}

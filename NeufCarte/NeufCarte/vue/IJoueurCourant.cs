using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NeufCarte.vue
{
    public interface IJoueurCourant
    {
        string PlayerCards { set; }
        int CardSelectedIndex { get; }
        string OtherPlayers { set; }
        Boolean Visible { get; set; }
        int PlayerSelectedIndex { get; }

        event EventHandler CardSelected;
        event EventHandler PlayerSelected;
    }
}

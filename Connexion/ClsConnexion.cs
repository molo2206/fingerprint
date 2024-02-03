
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apptest.Connexion
{
    public class ClsConnexion
    {
        public string chemin;
        public void connect()
        {
            chemin = File.ReadAllText(ClsConstante.Table.chemin);
        }
    }
}

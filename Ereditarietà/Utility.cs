using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà
{
    static class Utility
    {
        public static string StampaIndirizzo(this Indirizzo indirizzo)
        {
            return indirizzo.Via + " " + indirizzo.NumeroCivico + Environment.NewLine
                + indirizzo.Cap + " " + indirizzo.Comune + Environment.NewLine 
                + indirizzo.Provincia + " " + indirizzo.Nazione;
        }

        public static string ToString (this Indirizzo indirizzo)
        {
            return StampaIndirizzo(indirizzo);
        }
    }
}

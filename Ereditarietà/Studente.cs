using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà
{

    class Studente : Persona
    {
        public int Matricola { get; set; }
        public int AnnoIscrizione { get; set; }

        public Studente()
        {

        }
        public Studente(string nome, string cognome)
            : base (nome, cognome)
        {
            AnnoIscrizione = DateTime.Now.Year;
            Matricola = 0;
        }

        public override string GetDettaglioPersona()
        {
            return base.GetDettaglioPersona() + Environment.NewLine
                + Matricola + Environment.NewLine
                + AnnoIscrizione;
        }
    }
}

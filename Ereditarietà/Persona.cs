using System;
using System.Collections.Generic;

namespace Ereditarietà
{
    enum Sesso
    {
        N,
        M,
        F
    }

    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Età { get; set; }
        public Sesso Genere {get; set;}
        public DateTime DataDiNascita { get; set; }
        public Indirizzo IndirizzoDiResidenza { get; set; }
        public Indirizzo IndirizzoDiDomicilio { get; set; }

        public Persona()
        {

        }

        public Persona(string nome, string cognome, int età, Sesso genere, DateTime dataDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            Età = età;
            Genere = genere;
            DataDiNascita = dataDiNascita;
        }

        public Persona(string nome, string cognome)
        {
            Nome = nome;
            Cognome = cognome;
        }

        public Persona(string nome, string cognome, DateTime dataDiNascita)
        {
            Nome = nome;
            Cognome = cognome;
            DataDiNascita = dataDiNascita;

            var annoAttuale = DateTime.Now.Year;
            var annoDiNascita = dataDiNascita.Year;

            Età = annoAttuale - annoDiNascita;
        }

        public virtual string GetDettaglioPersona()
        {
            return Nome + System.Environment.NewLine +
                Cognome + System.Environment.NewLine +
                Età + System.Environment.NewLine +
                Genere + System.Environment.NewLine +
                DataDiNascita + System.Environment.NewLine;
        }
    }
}

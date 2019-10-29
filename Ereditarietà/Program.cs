using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ereditarietà
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime(1983, 7, 3);
            DateTime data2 = new DateTime(1986, 5, 18);

            Persona p1 = new Persona("Roberto", "Spagliccia", data1);
            Persona p2 = new Persona("Mario", "Rossi", 42, Sesso.M, data2);

            Console.WriteLine("I dettagli della persona p1 sono " 
                + System.Environment.NewLine 
                + p1.GetDettaglioPersona());

            Console.WriteLine("I dettagli della persona p2 sono " 
                + System.Environment.NewLine 
                + p2.GetDettaglioPersona());

            Studente s1 = new Studente("Francesco", "Totti");

            Console.WriteLine("Le informazioni dello studente sono: "
                + System.Environment.NewLine
                + s1.GetDettaglioPersona() + Environment.NewLine
                + s1.AnnoIscrizione + System.Environment.NewLine
                + s1.Matricola);

            Console.WriteLine("L'oggetto p1 è di tipo persona? " + (p1 is Persona));
            Console.WriteLine("L'oggetto s1 è di tipo studente? " + (s1 is Studente));

            Console.WriteLine("L'oggetto p1 è di tipo studente? " + (p1 is Studente));
            Console.WriteLine("L'oggetto s1 è di tipo persona? " + (s1 is Persona));


            Studente s2 = new Studente()
            {
                AnnoIscrizione = 2012,
                Nome = "Federica",
                Cognome = "Pellegrini",
                Genere = Sesso.F,
                DataDiNascita = new DateTime(1988, 8, 5),
                Matricola = 1
            };


            Persona p3 = new Persona()
            {
                Nome = "John",
                Cognome = "Doe",
                Genere = Sesso.M,
                DataDiNascita = new DateTime(1970, 1, 1),
                Età = 49
            };


            Console.WriteLine("s2 " + s2.GetDettaglioPersona());
            Console.WriteLine("p3 " + p3.GetDettaglioPersona());

            Indirizzo indirizzo1 = new Indirizzo(
                "Via Garibaldi",
                "185/b",
                "35127",
                "Padva",
                "PD",
                "Italia");

            indirizzo1.Comune = "Padova";

            string indirizzoDaStampare = Utility.StampaIndirizzo(indirizzo1);
            //espressioni equivalenti
            indirizzoDaStampare = indirizzo1.StampaIndirizzo();

            Console.WriteLine(indirizzo1.StampaIndirizzo());

            p3.IndirizzoDiResidenza = indirizzo1;

            p3.IndirizzoDiDomicilio = new Indirizzo(
                "Via Roma", "5", "00100", "Roma", "RM", "Italia");

            Console.WriteLine("L'indirizzo di domicilio di p3 è: " 
                + p3.IndirizzoDiDomicilio.StampaIndirizzo());

            s2.IndirizzoDiDomicilio = p3.IndirizzoDiDomicilio;

            Console.WriteLine("L'indirizzo di domicilio di s2 è: "
                + s2.IndirizzoDiDomicilio);

            Console.WriteLine("Fornisci un nuovo valore per la provincia di domicilio di s2");
            string nuovaProvincia = Console.ReadLine();


            var indirizzo = s2.IndirizzoDiDomicilio;
            var vecchiaProvincia = indirizzo.Provincia;

            indirizzo.Provincia = nuovaProvincia;
            if (indirizzo.Provincia == string.Empty)
            {
                indirizzo.Provincia = vecchiaProvincia;
            }
            Console.WriteLine(indirizzo.StampaIndirizzo());

            Console.ReadLine();
        }
    }
}
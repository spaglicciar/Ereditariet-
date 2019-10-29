namespace Ereditarietà
{
    struct Indirizzo
    {
        public string Via { get; set; }
        public string NumeroCivico { get; set; }
        public string Cap { get; set; }
        public string Comune { get; set; }
        public string Nazione { get; set; }
        private string prov;
        public string Provincia
        {
            get
            {
                return prov;
            }
            set
            {
                prov = string.Empty;
                if (value != null && value.Length == 2)
                {
                    prov = value;
                }
            }
        }

        public Indirizzo(string via, string numeroCivico, string cap,
            string comune, string provincia, string nazione)
        {
            Via = via;
            NumeroCivico = numeroCivico;
            Cap = cap;
            Comune = comune;
            prov = provincia;
            Nazione = nazione;
        }

        public override string ToString()
        {
            return this.StampaIndirizzo();
        }
    }
}

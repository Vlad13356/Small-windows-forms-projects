using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._03._18_L2_MSOA
{
    class Persoana
    {
        private string nume;
        private string telefon;
        private Categorie categorie;

        public Persoana(string nume, string telefon, Categorie categorie)
        {
            this.nume = nume;
            this.telefon = telefon;
            this.categorie = categorie;
        }

        [Description("Nume complet al persoanei"), Category("Date personale")]
        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        [Description("Telefonul persoanei"), Category("Date personale")]
        public string Telefon
        {
            get { return telefon; }
            set { telefon = value; }
        }
        [Description("Categorie"), Category("Categorie")]
        public Categorie Categorie
        {
            get { return categorie; }
            set { categorie = value; }
        }
    }

        enum Categorie : int
    {
        Prieteni,
        Colegi,
        Rude,
        Diversi
    };
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopApp.Data
{
    public class Livre
    {
        public UInt64 ISBN { get; set; }
        public string Titre { get; set; }
        public string Sous_Titre { get; set; }
        public string Auteurs_principaux { get; set; }
        public string Co_auteurs { get; set; }
        public string Editeur { get; set; }
        public string Collection { get; set; }
        public string Poche { get; set; }
        public Int16 Pages { get; set; }
        public Int16 Tome { get; set; }
        public Int16 Tomes { get; set; }
        public float Prix_reglemente { get; set; }
        public float Prix_achat { get; set; }
        public float Prix_vente { get; set; }
        public bool Occasion { get; set; }
    }
}

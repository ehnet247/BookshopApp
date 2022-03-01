using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIMockup.Models
{
    public class Livre
    {
        [Key]
        public UInt64 Ean { get; set; } // BIGINT NOT NULL
        public string Titre { get; set; } // VARCHAR(255) NOT NULL
        public string Auteurs { get; set; } // VARCHAR(255) NOT NULL
        public string Fournisseur { get; set; } // VARCHAR(127) NOT NULL
        public UInt16 Stock { get; set; } // NOT NULL
        public string Editeur { get; set; } // VARCHAR(127) NOT NULL
        public string Categorie { get; set; } // VARCHAR(127) NOT NULL
        public DateTime DatePublication { get; set; } // DATE NOT NULL
        public string Disponibilite { get; set; } // VARCHAR(127) NOT NULL
        public UInt16 Poids { get; set; } // NOT NULL
        public double PrixVente { get; set; } // MONEY NOT NULL
        public double PrixNeuf { get; set; } // MONEY
        public float TvaTaux { get; set; } // FLOAT
        public double TvaMontant { get; set; } // MONEY
    public bool Occasion { get; set; } // NOT NULL
        public string CollEditoriale { get; set; } // VARCHAR(127)
        public UInt16 Pages { get; set; }
        public UInt16 Tome { get; set; }
        public bool CoupDeCoeur { get; set; }
        public string AvisLibraire { get; set; } // TEXT

        public Livre()
        {
            Titre = string.Empty;
            Auteurs = string.Empty;
            Fournisseur = string.Empty;
            Editeur = string.Empty;
            Categorie = string.Empty;
            Disponibilite = string.Empty;
            CollEditoriale = string.Empty;
            AvisLibraire = string.Empty;
        }
    }
}

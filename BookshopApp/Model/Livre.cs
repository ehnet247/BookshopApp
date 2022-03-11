using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookshopApp.Model
{
    public class Livre
    {
        private UInt64 ean;
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
            Ean = 0;
            Titre = string.Empty;
            Auteurs = string.Empty;
            Fournisseur = string.Empty;
            Editeur = string.Empty;
            Categorie = string.Empty;
            Disponibilite = string.Empty;
            CollEditoriale = string.Empty;
            AvisLibraire = string.Empty;
            CoupDeCoeur = false;
        }
    }

    public class LivreString : Livre
    {
        public string Ean { get; set; }
        public string Titre { get; set; }
        public string Auteurs { get; set; }
        public string Fournisseur { get; set; }
        public string Stock { get; set; }
        public string Editeur { get; set; }
        public string Categorie { get; set; }
        public string DatePublication { get; set; }
        public string Disponibilite { get; set; }
        public string Poids { get; set; }
        public string PrixVente { get; set; }
        public string PrixNeuf { get; set; }
        public string TvaTaux { get; set; }
        public string TvaMontant { get; set; }
        public string Occasion { get; set; }
        public string CollEditoriale { get; set; }
        public string Pages { get; set; }
        public string Tome { get; set; }
        public string CoupDeCoeur { get; set; }
        public string AvisLibraire { get; set; }

        public LivreString(Livre source)
        {
            bool Empty = true;
            if ((source.Ean != 0) || (source.Titre != String.Empty)) Empty = false;
            if (Empty)
                Ean = string.Empty;
            else
                Ean = source.Ean.ToString();
            Titre = source.Titre;
            Auteurs = source.Auteurs;
            Fournisseur = source.Fournisseur;
            if (Empty)
                Stock = string.Empty;
            else
                Stock = source.Stock.ToString();
            Editeur = source.Editeur;
            Categorie = source.Categorie;
            if (Empty)
                DatePublication = string.Empty;
            else
                DatePublication = source.DatePublication.ToString();
            Disponibilite = source.Disponibilite;
            Poids = source.Poids.ToString();
            if (Empty)
                PrixVente = String.Empty;
            else
                PrixVente = source.PrixVente.ToString();
            if (Empty)
                PrixNeuf = string.Empty;
            else
                PrixNeuf = source.PrixNeuf.ToString();
            TvaTaux = source.TvaTaux.ToString();
            TvaMontant = source.TvaMontant.ToString();
            Occasion = source.Occasion.ToString();
            CollEditoriale = source.CollEditoriale;
            Pages = source.Pages.ToString();
            Tome = source.Tome.ToString();
            CoupDeCoeur = source.CoupDeCoeur.ToString();
            AvisLibraire = source.AvisLibraire;
        }
    }
}

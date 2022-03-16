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
        [NotMapped]
        public LivreString LivreString { get; set; }

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
            LivreString = new LivreString(this);
        }
    }

    public class LivreString
    {
        public string Ean
        {
            get
            {
                return LivreSource.Ean.ToString();
            }
            set
            {
                ulong convertedValue;
                ulong.TryParse(value, out convertedValue);
                LivreSource.Ean = convertedValue;

            }
        }
        public string Titre
        {
            get
            {
                return LivreSource.Titre;
            }
            set
            {
                LivreSource.Titre = value;
            }
        }
        public string Auteurs
        {
            get
            {
                return LivreSource.Auteurs;
            }
            set
            {
                LivreSource.Auteurs = value;
            }
        }
        public string Fournisseur
        {
            get
            {
                return LivreSource.Fournisseur;
            }
            set
            {
                LivreSource.Fournisseur = value;
            }
        }
        public string Quantite
        {
            get
            {
                return LivreSource.Stock.ToString();
            }
            set
            {
                ushort convertedValue;
                ushort.TryParse(value, out convertedValue);
                LivreSource.Stock = convertedValue;

            }
        }
        public string Editeur
        {
            get
            {
                return LivreSource.Editeur;
            }
            set
            {
                LivreSource.Editeur = value;
            }
        }
        public string Categorie
        {
            get
            {
                return LivreSource.Categorie;
            }
            set
            {
                LivreSource.Categorie = value;
            }
        }
        public string DatePublication
        {
            get
            {
                return LivreSource.Stock.ToString();
            }
            set
            {
                DateTime convertedValue;
                DateTime.TryParse(value, out convertedValue);
                LivreSource.DatePublication = convertedValue;

            }
        }
        public string Disponibilite
        {
            get
            {
                return LivreSource.Disponibilite;
            }
            set
            {
                LivreSource.Disponibilite = value;
            }
        }
        public string Poids
        {
            get
            {
                return LivreSource.Poids.ToString();
            }
            set
            {
                ushort convertedValue;
                ushort.TryParse(value, out convertedValue);
                LivreSource.Poids = convertedValue;

            }
        }
        public string PrixVente
        {
            get
            {
                return LivreSource.PrixVente.ToString();
            }
            set
            {
                double convertedValue;
                Double.TryParse(value, out convertedValue);
                LivreSource.PrixVente = convertedValue;

            }
        }
        public string PrixNeuf
        {
            get
            {
                return LivreSource.PrixNeuf.ToString();
            }
            set
            {
                double convertedValue;
                Double.TryParse(value, out convertedValue);
                LivreSource.PrixNeuf = convertedValue;

            }
        }
        public string TvaTaux
        {
            get
            {
                return LivreSource.TvaTaux.ToString();
            }
            set
            {
                float convertedValue;
                float.TryParse(value, out convertedValue);
                LivreSource.TvaTaux = convertedValue;

            }
        }
        public string TvaMontant
        {
            get
            {
                return LivreSource.TvaMontant.ToString();
            }
            set
            {
                double convertedValue;
                Double.TryParse(value, out convertedValue);
                LivreSource.TvaMontant = convertedValue;

            }
        }
        public string Occasion
        {
            get
            {
                if (LivreSource.Occasion)
                    return "Occasion";
                else
                    return "Neuf";
            }
            set
            {
                string newVal = value.ToLower();
                if (newVal != "neuf")
                {
                    LivreSource.Occasion = true;
                }
                else
                {
                    LivreSource.Occasion = false;
                }

            }
        }
        public string CollEditoriale
        {
            get
            {
                return LivreSource.CollEditoriale;
            }
            set
            {
                LivreSource.CollEditoriale = value;
            }
        }
        public string Pages { get; set; }
        public string Tome { get; set; }
        public string CoupDeCoeur
        {
            get
            {
                if (LivreSource.CoupDeCoeur)
                    return "Oui";
                else
                    return "";
            }
            set
            {
                string newVal = value.ToLower();
                if (newVal == "oui")
                {
                    LivreSource.CoupDeCoeur = true;
                }
                else
                {
                    LivreSource.CoupDeCoeur = false;
                }

            }
        }
        public string AvisLibraire
        {
            get
            {
                return LivreSource.AvisLibraire;
            }
            set
            {
                LivreSource.AvisLibraire = value;
            }
        }
        private Livre LivreSource;

        public LivreString(Livre source)
        {
            if (source == null)
                source = new Livre();
            LivreSource = source;
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
                Quantite = string.Empty;
            else
                Quantite = source.Stock.ToString();
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
            //Occasion = source.Occasion.ToString();
            if (Empty)
            {
                Occasion = "Neuf";
            }
            else if (source.Occasion == true)
            {
                Occasion = "Occasion";
            }
            else
            {
                Occasion = "Neuf";
            }
            CollEditoriale = source.CollEditoriale;
            Pages = source.Pages.ToString();
            Tome = source.Tome.ToString();
            CoupDeCoeur = source.CoupDeCoeur.ToString();
            AvisLibraire = source.AvisLibraire;
        }
    }
}

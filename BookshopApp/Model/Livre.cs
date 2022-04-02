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
        [Key]
        public UInt32 Ean { get; set; } // INTEGER NOT NULL
        public UInt64 Isbn13 { get; set; } // BIGINT
        public bool Occasion { get; set; } // BOOL NOT NULL
        public string Titre { get; set; } // NOT NULL
        public string Provenance { get; set; } // TEXT
        public string Auteurs { get; set; } // TEXT
        public string Etat { get; set; } // TEXT
        public string Fournisseur { get; set; } // TEXT
        public UInt16 Stock { get; set; } // NOT NULL
        public string Editeur { get; set; } // TEXT
        public string Categorie { get; set; } // TEXT
        public DateTime DatePublication { get; set; } // DATE
        public string Disponibilite { get; set; } // TEXT
        public UInt16 Poids { get; set; } //
        public double PrixVente { get; set; } // REAL NOT NULL
        public double PrixAchat { get; set; } // REAL
        public double PrixNeuf { get; set; } // REAL
        public float TvaTaux { get; set; } // REAL
        public double TvaMontant { get; set; } // REAL
        public string CollEditoriale { get; set; } // TEXT
        public UInt16 Pages { get; set; }
        public UInt16 Tome { get; set; }
        public bool CoupDeCoeur { get; set; }
        public string AvisLibraire { get; set; } // TEXT
        [NotMapped]
        public LivreString LivreString { get; set; }

        public Livre()
        {
            Ean = 0;
            Isbn13 = 0;
            Occasion = true;
            Titre = string.Empty;
            Provenance = string.Empty;
            Auteurs = string.Empty;
            Etat = string.Empty;
            Fournisseur = string.Empty;
            Stock = 0;
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
                if (LivreSource.Isbn13 == 0)
                    return String.Empty;
                else
                    return LivreSource.Ean.ToString();
            }
            set
            {
                uint convertedValue;
                uint.TryParse(value, out convertedValue);
                LivreSource.Ean = convertedValue;

            }
        }
        public string Isbn13
        {
            get
            {
                if (LivreSource.Isbn13 == 0)
                    return String.Empty;
                else
                    return LivreSource.Isbn13.ToString();
            }
            set
            {
                uint convertedValue;
                uint.TryParse(value, out convertedValue);
                LivreSource.Isbn13 = convertedValue;

            }
        }
        public string Occasion
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                {
                    if (LivreSource.Occasion)
                        return "Occasion";
                    else
                        return "Neuf";
                }
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
        public string Titre
        {
            get
            {
                if (LivreSource.Isbn13 == 0)
                    return String.Empty;
                else
                    return LivreSource.Titre;
            }
            set
            {
                LivreSource.Titre = value;
            }
        }
        public string Provenance
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.Provenance;
            }
            set
            {
                LivreSource.Provenance = value;
            }
        }
        public string Auteurs
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.Auteurs;
            }
            set
            {
                LivreSource.Auteurs = value;
            }
        }
        public string Etat
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.Etat;
            }
            set
            {
                LivreSource.Etat = value;
            }
        }
        public string Fournisseur
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.Fournisseur;
            }
            set
            {
                LivreSource.Fournisseur = value;
            }
        }
        public string Stock
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.DatePublication.ToString();
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.PrixVente.ToString();
            }
            set
            {
                double convertedValue;
                Double.TryParse(value, out convertedValue);
                LivreSource.PrixVente = convertedValue;

            }
        }
        public string PrixAchat
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.PrixAchat.ToString();
            }
            set
            {
                double convertedValue;
                Double.TryParse(value, out convertedValue);
                LivreSource.PrixAchat = convertedValue;

            }
        }
        public string PrixNeuf
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.TvaMontant.ToString();
            }
            set
            {
                double convertedValue;
                Double.TryParse(value, out convertedValue);
                LivreSource.TvaMontant = convertedValue;

            }
        }
        public string CollEditoriale
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.CollEditoriale;
            }
            set
            {
                LivreSource.CollEditoriale = value;
            }
        }
        public string Pages
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.Pages.ToString();
            }
            set
            {
                ushort convertedValue;
                ushort.TryParse(value, out convertedValue);
                LivreSource.Pages = convertedValue;

            }
        }
        public string Tome
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
                    return LivreSource.Tome.ToString();
            }
            set
            {
                ushort convertedValue;
                ushort.TryParse(value, out convertedValue);
                LivreSource.Tome = convertedValue;

            }
        }
        public string CoupDeCoeur
        {
            get
            {
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
                if (LivreSource.Ean == 0)
                    return String.Empty;
                else
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
            {
                source = new Livre();
            }
            LivreSource = source;
        }
    }
}

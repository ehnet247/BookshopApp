using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using BookshopApp.Model;
using System.Windows.Input;

namespace BookshopApp.ViewModels
{
    internal class ViewModelStockReception : ObservableRecipient
    {
        private LivreDbContext DbContext;
        public ICommand CommandAjouter { get; set; }
        private Livre livreAAjouter;
        public Livre LivreAAjouter
        {
            get
            {
                return livreAAjouter;
            }
            set
            {
                livreAAjouter = value;
                OnPropertyChanged("LivreAChercher");
            }
        }

        private LivreString livreStringAAjouter;
        public LivreString LivreStringAAjouter
        {
            get
            {
                return livreStringAAjouter;
            }
            set
            {
                livreStringAAjouter = value;
                OnPropertyChanged("LivreStringAAjouter");
            }
        }
        private IEnumerable dataSource;
        public IEnumerable DataSource
        {
            get
            {
                return dataSource;
            }
            set
            {
                dataSource = value;
                OnPropertyChanged("DataSource");
            }
        }

        public ViewModelStockReception()
        {
            DbContext = new LivreDbContext();
            if (DbContext != null)
            {
                DataSource = DbContext.Livres.ToList();
            }
            
            CommandAjouter = new BaseCommand(AjouterLivre);
            LivreAAjouter = new Livre();
            LivreStringAAjouter = new LivreString(LivreAAjouter);
        }

        private void AjouterLivre(object obj)
        {
            if (DbContext != null)
            {
                // Verifier que les champs obligatoires soient renseignes
                if (ChampsAvantAjoutCompletes() == false)
                {
                    // Afficher un message d'erreur
                }
                else if (CreateLivreFromLivreString(LivreStringAAjouter))
                {
                        // Si le livre fait partie des references, ajouter la quantite recue
                        var existingEan = DbContext.Livres.Count(a => a.Ean == LivreAAjouter.Ean);
                        if (existingEan != 0)
                        {
                        var livre = DbContext.Livres.Single(l => l.Ean == LivreAAjouter.Ean);
                        livre.Stock += LivreAAjouter.Stock;
                        DbContext.SaveChanges();
                        DbContext.Update(livre);
                    }
                        else
                        {
                            // Sinon, l'ajouter aux references et completer les informations si besoin
                            DbContext.Livres.Add(LivreAAjouter);
                            LivreAAjouter = new Livre();
                        }

                        DbContext.SaveChanges();
                    }
            }
        }

        private bool CreateLivreFromLivreString(LivreString livreStringAAjouter)
        {
            bool ManageToCreate = true;
            Livre livreAAjouter = new Livre();
            if (uint.TryParse(LivreStringAAjouter.Ean, out uint ean) == true)
            {
                livreAAjouter.Ean = ean;
            }
            else
            {
                ManageToCreate = false;
                // Afficher un message d'erreur
            }

            if (UInt16.TryParse(LivreStringAAjouter.Stock, out ushort stock) == true)
            {
                livreAAjouter.Stock = stock;
            }
            else
            {
                ManageToCreate = false;
                // Afficher un message d'erreur
            }

            if (LivreStringAAjouter.DatePublication != string.Empty)
            {
                if (DateTime.TryParse(LivreStringAAjouter.DatePublication, out DateTime datePublication) == true)
                {
                    livreAAjouter.DatePublication = datePublication;
                }
                else
                {
                    ManageToCreate = false;
                    // Afficher un message d'erreur
                }
            }

            if (LivreStringAAjouter.Poids != string.Empty)
            {
                if (UInt16.TryParse(LivreStringAAjouter.Poids, out ushort poids) == true)
                {
                    livreAAjouter.Poids = poids;
                }
                else
                {
                    ManageToCreate = false;
                    // Afficher un message d'erreur
                }
            }

            if (LivreStringAAjouter.PrixVente != string.Empty)
            {
                if (Double.TryParse(LivreStringAAjouter.PrixVente, out double prixVente) == true)
                {
                    livreAAjouter.PrixVente = prixVente;
                }
                else
                {
                    ManageToCreate = false;
                    // Afficher un message d'erreur
                }
            }

            if (LivreStringAAjouter.PrixNeuf != string.Empty)
            {
                if (Double.TryParse(LivreStringAAjouter.PrixNeuf, out double prixNeuf) == true)
                {
                    livreAAjouter.PrixNeuf = prixNeuf;
                }
                else
                {
                    ManageToCreate = false;
                    // Afficher un message d'erreur
                }
            }

            if (LivreStringAAjouter.TvaTaux != string.Empty)
            {
                if (float.TryParse(LivreStringAAjouter.TvaTaux, out float tvaTaux) == true)
                {
                    livreAAjouter.TvaTaux = tvaTaux;
                }
                else
                {
                    ManageToCreate = false;
                    // Afficher un message d'erreur
                }
            }

            if (LivreStringAAjouter.TvaMontant != string.Empty)
            {
                if (float.TryParse(LivreStringAAjouter.TvaMontant, out float tvaMontant) == true)
                {
                    livreAAjouter.TvaMontant = tvaMontant;
                }
                else
                {
                    ManageToCreate = false;
                    // Afficher un message d'erreur
                }
            }

            bool occasion = false;
            if ((livreStringAAjouter.Occasion.ToLower() == "oui") || (livreStringAAjouter.Occasion == "1"))
            {
                occasion = true;
            }
            livreAAjouter.Occasion = occasion;

            if (LivreStringAAjouter.Pages != string.Empty)
            {
                if (UInt16.TryParse(LivreStringAAjouter.Pages, out ushort pages) == true)
                {
                    livreAAjouter.Pages = pages;
                }
                else
                {
                    ManageToCreate = false;
                    // Afficher un message d'erreur
                }
            }

            if (LivreStringAAjouter.Tome != string.Empty)
            {
                if (UInt16.TryParse(LivreStringAAjouter.Tome, out ushort tome) == true)
                {
                    livreAAjouter.Tome = tome;
                }
                else
                {
                    ManageToCreate = false;
                    // Afficher un message d'erreur
                }
            }

            bool coupDeCoeur = false;
            if ((livreStringAAjouter.CoupDeCoeur.ToLower() == "oui") || (livreStringAAjouter.CoupDeCoeur == "1"))
            {
                coupDeCoeur = true;
            }
            livreAAjouter.CoupDeCoeur = coupDeCoeur;

            if (ManageToCreate == true)
            {
                LivreAAjouter = livreAAjouter;
            }
            return ManageToCreate;
        }

        private bool ChampsAvantAjoutCompletes()
        {
            bool returnValue = false;
            if ((LivreStringAAjouter.Ean != string.Empty)
                && (LivreStringAAjouter.Stock != string.Empty))
            {
                returnValue = true;
            }
            return returnValue;
        }
    }
}

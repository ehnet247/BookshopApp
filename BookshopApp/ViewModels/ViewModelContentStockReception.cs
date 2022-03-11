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
    internal class ViewModelContentStockReception : ObservableRecipient
    {
        private Livre nouveauLivre;
        public Livre NouveauLivre
        {
            get
            {
                return nouveauLivre;
            }
            set
            {
                nouveauLivre = value;
                OnPropertyChanged("NouveauLivre");
            }
        }
        private IEnumerable dataSource;
        private LivreDbContext DbContext;
        public ICommand CommandAjouter { get; set; }
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

        public ViewModelContentStockReception()
        {
            DbContext = new LivreDbContext();
            if (DbContext != null)
            {
                DataSource = DbContext.Livres.ToList();
            }
            
            CommandAjouter = new BaseCommand(AjouterLivre);
        }

        public void AjouterLivre()
        {
            if (DbContext != null)
            {
                DbContext.Livres.Add(NouveauLivre);
            }
        }

        private void AjouterLivre(object obj)
        {
            if (DbContext != null)
            {
                DbContext.Livres.Add(NouveauLivre);
                DbContext.SaveChanges();
            }
        }
    }
}

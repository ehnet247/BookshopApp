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
    internal class ViewModelStockEdit : ObservableRecipient
    {
        private IEnumerable dataSource;
        private Livre selectedRow = new Livre();
        private LivreDbContext DbContext;
        public ICommand CommandValider { get; set; }
        public ICommand CommandSupprimer { get; set; }

        //private LivreString livreStringAEditer;
        //public LivreString LivreStringAEditer
        //{
        //    get
        //    {
        //        return livreStringAEditer;
        //    }
        //    set
        //    {
        //        livreStringAEditer = value;
        //        OnPropertyChanged("LivreStringAEditer");
        //    }
        //}

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

        public Livre SelectedRow
        {
            get
            {
                return selectedRow;
            }
            set
            {
                selectedRow = value;
                //LivreStringAEditer = new LivreString(selectedRow);
                OnPropertyChanged("SelectedRow");
            }
        }

        public ViewModelStockEdit()
        {
            DbContext = new LivreDbContext();
            if (DbContext != null)
            {
                DataSource = DbContext.Livres.ToList();
            }
            CommandValider = new BaseCommand(ValiderModif);
            CommandSupprimer = new BaseCommand(SupprimerRef);
        }

        private void ValiderModif(object obj)
        {
            DbContext.Update(SelectedRow);
            DbContext.SaveChanges();
        }

        private void SupprimerRef(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

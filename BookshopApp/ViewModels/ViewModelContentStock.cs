using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookshopApp.Model;
using BookshopApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace BookshopApp.ViewModels
{
    public class ViewModelContentStock : ObservableRecipient
    {
        private IEnumerable dataSource;
        private LivreDbContext DbContext;
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

        public ViewModelContentStock()
        {
            //dataSource = null;
            DbContext = new LivreDbContext();
            if (DbContext != null)
            {
                DataSource = DbContext.Livres.ToList();
            }
        }
        public override string ToString()
        {
            return "Stock";
        }
    }
}

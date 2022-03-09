﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using CommunityToolkit.Mvvm.ComponentModel;
using BookshopApp.Model;

namespace BookshopApp.ViewModels
{
    internal class ViewModelContentStockRecherche : ObservableRecipient
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

        public ViewModelContentStockRecherche()
        {
            DbContext = new LivreDbContext();
            if (DbContext != null)
            {
                DataSource = DbContext.Livres.ToList();
            }
        }
    }
}

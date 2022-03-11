﻿using System;
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
    internal class ViewModelContentStockRecherche : ObservableRecipient
    {
        private IEnumerable dataSource;
        private LivreDbContext DbContext;
        public ICommand CommandRechercher { get; set; }

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
        private Livre livreAChercher;
        public Livre LivreAChercher
        {
            get
            {
                return livreAChercher;
            }
            set
            {
                livreAChercher = value;
                OnPropertyChanged("LivreAChercher");
            }
        }

        public ViewModelContentStockRecherche()
        {
            DbContext = new LivreDbContext();
            CommandRechercher = new BaseCommand(Rechercher);
            LivreAChercher = new Livre();
            if (DbContext != null)
            {
                DataSource = DbContext.Livres.ToList();
            }
        }

        private void Rechercher(object obj)
        {
        }
    }
}

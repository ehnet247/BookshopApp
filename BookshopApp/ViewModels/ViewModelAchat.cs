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
    internal class ViewModelAchat : ObservableRecipient
    {
        private LivreDbContext DbContext;
        public ICommand CommandEvaluer { get; set; }
        private LivreString livreStringAAcheter;
        public LivreString LivreStringAAcheter
        {
            get
            {
                return livreStringAAcheter;
            }
            set
            {
                livreStringAAcheter = value;
                OnPropertyChanged("LivreStringAAcheter");
            }
        }
        public override string ToString()
        {
            return "Achat";
        }

        public ViewModelAchat()
        {
            CommandEvaluer = new BaseCommand(EvaluerLivre);
            DbContext = new LivreDbContext();
        }

        private void EvaluerLivre(object obj)
        {
            if (LivreStringAAcheter.Isbn13 != string.Empty)
            {
            }
        }
    }
}

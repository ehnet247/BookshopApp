using BookshopApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BookshopApp.ViewModels
{
    internal class ViewModelStockNavigation : ObservableRecipient
    {

        public object StockRechercheTabContent { get; set; }
        public object StockModifTabContent { get; set; }
        public object StockReceptionTabContent { get; set; }

        private object selectedTabViewModel = new ViewModelContentStockRecherche();

        public object SelectedTabViewModel

        {

            get { return selectedTabViewModel; }

            set
            {
                if (value != null)
                {
                    selectedTabViewModel = value;
                    OnPropertyChanged("SelectedTabViewModel");
                }

            }

        }

        public ViewModelStockNavigation()
        {
            StockRechercheTabContent = new ViewModelContentStockRecherche();
            StockModifTabContent = new ViewModelContentStockModif();
            StockReceptionTabContent = new ViewModelContentStockReception();
        }

    }
}

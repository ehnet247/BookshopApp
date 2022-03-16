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
    internal class ViewModelNavigation : ObservableRecipient
    {

        public ICommand CommandCaisse { get; set; }
        public ICommand CommandAchat { get; set; }
        public ICommand CommandCdeClient { get; set; }
        public ICommand CommandStock { get; set; }
        public ICommand CommandStockReception { get; set; }
        public ICommand CommandStockModif { get; set; }
        public ICommand CommandStockRecherche { get; set; }
        public ICommand CommandHisto { get; set; }
        public ICommand CommandAdmin { get; set; }

        private object selectedContentViewModel = new ViewModelStock();
        private object selectedMenuViewModel = new ViewModelMenuStock();

        public object SelectedContentViewModel

        {

            get { return selectedContentViewModel; }

            set
            {
                if (value != null)
                {
                    selectedContentViewModel = value;
                    OnPropertyChanged("SelectedContentViewModel");
                }

            }

        }

        public object SelectedMenuViewModel

        {

            get { return selectedMenuViewModel; }

            set
            {
                if (value != null)
                {
                    selectedMenuViewModel = value;
                    OnPropertyChanged("SelectedMenuViewModel");
                }

            }

        }

        public ViewModelNavigation()

        {
            CommandCaisse = new BaseCommand(OpenCaisse);
            CommandAchat = new BaseCommand(OpenAchat);
            CommandCdeClient = new BaseCommand(OpenCdeClient);
            CommandStock = new BaseCommand(OpenStock);
            CommandHisto = new BaseCommand(OpenHisto);
            CommandAdmin = new BaseCommand(OpenAdmin);

        }
        #region Open methods

        private void OpenCaisse(object obj)
        {

            SelectedContentViewModel = new ViewModelCaisse();
            SelectedMenuViewModel = new ViewModelMenuCaisse();

        }

        private void OpenAchat(object obj)
        {

            SelectedContentViewModel = new ViewModelAchat();
            SelectedMenuViewModel = new ViewModelMenuAchat();

        }

        private void OpenCdeClient(object obj)
        {

            SelectedContentViewModel = new ViewModelCdeClient();
            SelectedMenuViewModel = new ViewModelMenuCdeClient();

        }

        private void OpenStockReception(object obj)
        {

            SelectedContentViewModel = new ViewModelStockReception();
            SelectedMenuViewModel = new ViewModelMenuStock();

        }

        private void OpenStock(object obj)
        {

            SelectedContentViewModel = new ViewModelStock();
            SelectedMenuViewModel = new ViewModelMenuStock();

        }

        private void OpenStockModif(object obj)

        {

            SelectedContentViewModel = new ViewModelStockEdit();
            SelectedMenuViewModel = new ViewModelMenuStock();

        }

        private void OpenStockRecherche(object obj)

        {

            SelectedContentViewModel = new ViewModelStockRecherche();
            SelectedMenuViewModel = new ViewModelMenuStock();

        }

        private void OpenHisto(object obj)

        {

            SelectedContentViewModel = new ViewModelHisto();
            SelectedMenuViewModel = new ViewModelMenuHisto();

        }

        private void OpenAdmin(object obj)

        {

            SelectedContentViewModel = new ViewModelAdmin();
            SelectedMenuViewModel = new ViewModelMenuAdmin();

        }
        #endregion

        //public event PropertyChangedEventHandler PropertyChanged;

        /*private void OnPropertyChanged(string propName)

        {

            if (PropertyChanged != null)

            {

                PropertyChanged(this, new PropertyChangedEventArgs(propName));

            }

        }*/

    }

    // Following method has been copied from
    // https://stackoverflow.com/questions/38489354/implement-a-command-object-that-changes-a-property-on-my-viewmodel
    public class BaseCommand : ICommand
    {
        private Action<object> _method;
        public event EventHandler CanExecuteChanged;

        public BaseCommand(Action<object> method)
        {
            _method = method;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _method.Invoke(parameter);
        }
    }
}

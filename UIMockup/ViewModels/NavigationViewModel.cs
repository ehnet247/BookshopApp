using UIMockup.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace UIMockup.ViewModels
{
    internal class NavigationViewModel : INotifyPropertyChanged
    {

        public ICommand CaisseCommand { get; set; }
        public ICommand AchatCommand { get; set; }
        public ICommand CdeClientCommand { get; set; }
        public ICommand StockCommand { get; set; }
        public ICommand HistoCommand { get; set; }
        public ICommand AdminCommand { get; set; }

        private object selectedContentViewModel = new StockContentViewModel();
        private object selectedMenuViewModel = new StockMenuViewModel();

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

        public NavigationViewModel()

        {
            CaisseCommand = new BaseCommand(OpenCaisse);
            AchatCommand = new BaseCommand(OpenAchat);
            CdeClientCommand = new BaseCommand(OpenCdeClient);
            StockCommand = new BaseCommand(OpenStock);
            HistoCommand = new BaseCommand(OpenHisto);
            AdminCommand = new BaseCommand(OpenAdmin);

        }
        #region Open methods

        private void OpenCaisse(object obj)

        {

            SelectedContentViewModel = new CaisseContentViewModel();
            SelectedMenuViewModel = new CaisseMenuViewModel();

        }

        private void OpenAchat(object obj)

        {

            SelectedContentViewModel = new AchatContentViewModel();
            SelectedMenuViewModel = new AchatMenuViewModel();

        }

        private void OpenCdeClient(object obj)

        {

            SelectedContentViewModel = new CdeClientContentViewModel();
            SelectedMenuViewModel = new CdeClientMenuViewModel();

        }

        private void OpenStock(object obj)

        {

            SelectedContentViewModel = new StockContentViewModel();
            SelectedMenuViewModel = new StockMenuViewModel();

        }

        private void OpenHisto(object obj)

        {

            SelectedContentViewModel = new HistoContentViewModel();
            SelectedMenuViewModel = new HistoMenuViewModel();

        }

        private void OpenAdmin(object obj)

        {

            SelectedContentViewModel = new AdminContentViewModel();
            SelectedMenuViewModel = new AdminMenuViewModel();

        }
        #endregion

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propName)

        {

            if (PropertyChanged != null)

            {

                PropertyChanged(this, new PropertyChangedEventArgs(propName));

            }

        }

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

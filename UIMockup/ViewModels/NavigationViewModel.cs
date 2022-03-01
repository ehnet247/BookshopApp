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

        public ICommand StockCommand { get; set; }

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

            StockCommand = new BaseCommand(OpenStock);

        }

        private void OpenCaisse(object obj)

        {

            SelectedContentViewModel = new CaisseContentViewModel();
            SelectedMenuViewModel = new CaisseMenuViewModel();

        }

        private void OpenStock(object obj)

        {

            SelectedContentViewModel = new StockContentViewModel();
            SelectedMenuViewModel = new StockMenuViewModel();

        }

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

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

        private object selectedViewModel = new StockViewModel();

        public object SelectedViewModel

        {

            get { return selectedViewModel; }

            set { selectedViewModel = value; OnPropertyChanged("SelectedViewModel"); }

        }



        public NavigationViewModel()

        {

            CaisseCommand = new BaseCommand(OpenCaisse);

            StockCommand = new BaseCommand(OpenStock);

        }

        private void OpenCaisse(object obj)

        {

            SelectedViewModel = new CaisseViewModel();

        }

        private void OpenStock(object obj)

        {

            SelectedViewModel = new StockViewModel();

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

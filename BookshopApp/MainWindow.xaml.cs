using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BookshopApp.Model;
using BookshopApp.ViewModels;

namespace BookshopApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public readonly string StartupTab = "Stock";

        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new ViewModelNavigation();
            GetLivres();
            CheckTab(StartupTab);
        }

        private void GetLivres()
        {
            //LivresDG.ItemsSource = DbContext.Livres.ToList();
        }

        private void NavToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            string selectedTab = string.Empty;
            if (sender != null)
            {
                Type refType = typeof(ToggleButton);
                if (sender.GetType() == refType)
                {
                    selectedTab = ((ToggleButton)sender).Content.ToString();
                    UncheckTabsExcept(selectedTab);
                }
            }
        }

        private void UncheckTabsExcept(string selectedTab)
        {
            foreach (var item in NavPanel.Children)
            {
                Type refType = typeof(ToggleButton);
                if (item.GetType() == refType)
                    if (((ToggleButton)item).Content.ToString() != selectedTab)
                    {
                        ((ToggleButton)item).IsChecked = false;
                    }
            }
        }

        private void CheckTab(string selectedTab)
        {
            foreach (var item in NavPanel.Children)
            {
                Type refType = typeof(ToggleButton);
                if (item.GetType() == refType)
                    if (((ToggleButton)item).Content.ToString() == selectedTab)
                    {
                        ((ToggleButton)item).IsChecked = true;
                    }
            }
        }
    }
}

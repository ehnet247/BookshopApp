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

namespace UIMockup.UC
{
    /// <summary>
    /// Interaction logic for UserControlStock.xaml
    /// </summary>
    public partial class NavUC : UserControl
    {
        public NavUC()
        {
            InitializeComponent();
        }

        private void NavToggleButton_Checked(object sender, RoutedEventArgs e)
        {
            //foreach (var child in LogicalTreeHelper.GetChildren(NavPanelLeft))
            foreach (var child in NavPanelLeft.Children)
            {
                if ((child != null) && (child.GetType() == typeof(ToggleButton)))
                {
                    ToggleButton clickedTb = (ToggleButton)sender;
                    ToggleButton tb = (ToggleButton)child;
                    if (tb.Content != clickedTb.Content)
                    {
                        tb.IsChecked = false;
                    }
                    else
                    {
                        tb.IsChecked = true;
                    }
                }
            }
        }
    }
}

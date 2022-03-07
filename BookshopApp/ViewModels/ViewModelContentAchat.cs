using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;

namespace BookshopApp.ViewModels
{
    public class ViewModelContentAchat : ObservableRecipient
    {
        public override string ToString()
        {
            return "Achat";
        }
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookshopApp.Model;
using BookshopApp.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using Microsoft.Extensions.DependencyInjection;

namespace BookshopApp.ViewModels
{
    public class ViewModelStock : ObservableRecipient
    {

        public ViewModelStock()
        {
        }

        public override string ToString()
        {
            return "Stock";
        }
    }
}

using Demo02.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo02.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GroupedListView : ContentPage
    {
        public GroupedListView()
        {
            BindingContext = new GroupedListViewModel();

            InitializeComponent();

            
        }
    }
}
using Demo05.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo05.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}
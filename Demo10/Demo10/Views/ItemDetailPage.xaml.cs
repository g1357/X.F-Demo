using Demo10.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo10.Views
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
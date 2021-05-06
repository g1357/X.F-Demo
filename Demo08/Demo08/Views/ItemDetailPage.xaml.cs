using Demo08.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo08.Views
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
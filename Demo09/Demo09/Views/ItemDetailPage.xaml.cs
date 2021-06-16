using Demo09.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace Demo09.Views
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
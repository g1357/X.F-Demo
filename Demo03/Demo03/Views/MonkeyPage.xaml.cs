using Demo03.ModelViews;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo03.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonkeyPage : ContentPage
    {
        public MonkeyPage()
        {
            InitializeComponent();

            BindingContext = new MonkeyViewModel(this);
        }
    }
}
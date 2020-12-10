using Demo06.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Demo06.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        Page _page;

        private string _message;

        public string Message
        {
            get { return _message; }
            set { SetProperty(ref _message, value); }
        }
        public ICommand GridPageCommand => new Command(async () =>
        {
            await _page.Navigation.PushAsync(new GridPage());
            Message = "Было выбрано Grid Page.";
        });

        public ICommand ListViewGridCommand => new Command(async () =>
        {
            await _page.Navigation.PushAsync(new ListViewGridPage());
            Message = "Было выбрано |ListViewGrid Page.";
        });

        public MainViewModel(Page page)
        {
            _page = page;
        }
    }
}

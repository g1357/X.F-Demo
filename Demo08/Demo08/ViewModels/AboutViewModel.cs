﻿using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Demo08.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ICommand OpenFirstPageCommand => new Command(async () =>
        {
            await Shell.Current.GoToAsync("//FirstPage");
        });
        public AboutViewModel()
        {
            Title = "About";
            OpenWebCommand = new Command(async () => await Browser.OpenAsync("https://aka.ms/xamarin-quickstart"));
        }

        public ICommand OpenWebCommand { get; }
    }
}
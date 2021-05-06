using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Demo08.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FirstPage : ContentPage
    {
        public FirstPage()
        {
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            //var answer = DisplayAlert("ВНИММАНИЕ!", "Возвращаться некуда! Выйти из приложения", "Yes", "No")
            //    .GetAwaiter().GetResult();
            //return !answer;
            //var res = DisplayAlert("ВНИММАНИЕ!", "Возвращаться некуда!", "Ok", "Cancel")
            //    .GetAwaiter().GetResult();
            //var answer = task.Result;
            //return true;
            bool answer = true;
            var task = Task<bool>.Run(() =>
           {
               //bool answer = false;
               Device.BeginInvokeOnMainThread(async () =>
                    {
                   var ans = await DisplayAlert("ВНИММАНИЕ!", "Возвращаться некуда! Выйти из приложения", "Yes", "No");
                   answer = ans;
               });
               return answer;
           });
            answer = task.GetAwaiter().GetResult();
            return !answer;
            //var answer = new Task<bool>.Run(async () =>
            //{
            //    return await DisplayAlert("ВНИММАНИЕ!", "Возвращаться некуда! Выйти из приложения", "Yes", "No");
            //}).Result;
            //return !answer;
            //var task = DisplayAlert("ВНИММАНИЕ!", "Возвращаться некуда! Выйти из приложения", "Yes", "No").RunSynchronously();
            //task.Wait();
            //return !task.Result;
        }
    }
}
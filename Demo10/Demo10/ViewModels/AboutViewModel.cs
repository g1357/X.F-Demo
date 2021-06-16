using Demo10.Views;
using System;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Demo10.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        AboutPage page;
        public ICommand OpenWebCommand { get; }
        public ICommand ShowAlertCommand { get; }

        public AboutViewModel(AboutPage page)
        {
            this.page = page;

            Title = "About";
            OpenWebCommand = new Command(async () => 
                await Browser.OpenAsync("https://aka.ms/xamarin-quickstart")
            );
            ShowAlertCommand = new Command(async () =>
            {
                var answer = await page.DisplayAlert("Dialog Title", "Message", "Ok", "Cancel");
                await page.DisplayAlert("Result", $"Your choice {answer}.", "Close");
                var action = await page.DisplayActionSheet("Выберите действие:", "Отмена",
                    "Удаление", "Действие1", "Действие2", "Действие3");
                await page.DisplayAlert("Сделанный выбор", $"Вы выбрали {action}.", "Закрыть");
            });
        }

    }
}
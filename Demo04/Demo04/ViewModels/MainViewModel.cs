using System;
using System.Collections.Generic;
using System.Text;

namespace Demo04.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public Observable<string> Name { get; set; }
        public Observable<string> Text { get; set; } = new Observable<string>();
        public MainViewModel()
        {
            Name = new Observable<string>(() =>
            {
                Text.MyProperty = "Value Changed to" + Name.MyProperty;
            });
            Name.MyProperty = "Grigory!";
        }
    }
}

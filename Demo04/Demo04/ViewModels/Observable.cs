using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace Demo04.ViewModels
{
    public class Observable<T> : INotifyPropertyChanged
    {
        private Action _action;
        private T _myFiels;
        public T MyProperty
        {
            get => _myFiels;
            set
            {
                if (SetProperty(ref _myFiels, value))
                {
                    _action?.Invoke();
                }
            }
        }

        public Observable(Action action = null)
        {
            _action = action;
        }
        protected bool SetProperty<T>(ref T backingStore, T value,
            [CallerMemberName] string propertyName = "",
            Action onChanged = null)
        {
            if (EqualityComparer<T>.Default.Equals(backingStore, value))
                return false;

            backingStore = value;
            onChanged?.Invoke();
            OnPropertyChanged(propertyName);
            return true;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

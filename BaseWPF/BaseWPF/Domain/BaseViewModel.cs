using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BaseWPF.Domain
{
    public class BaseViewModel : BaseBinding
    {
        string _title;
        public string Title
        {
            get { return _title; }
            set { _title = value; OnPropertyChanged(); }
        }

        bool _isBusy;
        public bool IsBusy
        {
            get { return _isBusy; }
            set { _isBusy = value; OnPropertyChanged(); }
        }

        public BaseViewModel(string title)
        {
            Title = title;
        }
    }
}

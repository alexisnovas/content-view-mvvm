using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace HomeUI.ViewModels
{
    class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

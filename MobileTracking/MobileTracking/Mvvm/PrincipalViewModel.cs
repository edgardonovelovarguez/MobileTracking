using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MobileTracking.Mvvm
{
    public class PrincipalViewModel: INotifyPropertyChanged
    {
        public PrincipalViewModel()
        {

        }

        #region Property Changed
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}

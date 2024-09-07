using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanging
    {
        public event PropertyChangingEventHandler? PropertyChanging;

        protected void onPropertyChanged(string propertyNamee)
        {
            PropertyChanging?.Invoke(this, new PropertyChangingEventArgs(propertyNamee));
        }
    }
}

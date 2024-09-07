using MVVMTest.Models;
using MVVMTest.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.ViewModels
{
    public class MainViewModel : BaseViewModel
    {


        private NavigationStore _navigationStore;
        public BaseViewModel CurrentViewModel => _navigationStore.CurrentViewModel;  

        public MainViewModel(NavigationStore navigationStore)
        {
            _navigationStore = navigationStore;
        }
    }
}

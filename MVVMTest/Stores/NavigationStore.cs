using MVVMTest.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMTest.Stores
{
    public class NavigationStore
    {
        private BaseViewModel _currentViewModel;

        public BaseViewModel CurrentViewModel 
        {
            get
            {
                return _currentViewModel;
            }
            set
            {
                _currentViewModel = value;
            }   
        }
    }
}

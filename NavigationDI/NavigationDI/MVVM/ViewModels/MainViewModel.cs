using NavigationDI.Core;
using NavigationDI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigationDI.MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
		public INavigationService navigationService { get; set; }

		public MainViewModel()
		{
			
		}

		


	}
}

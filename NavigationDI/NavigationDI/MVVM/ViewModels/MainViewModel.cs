using NavigationDI.Core;
using NavigationDI.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace NavigationDI.MVVM.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
		private INavigationService _navigation;

		public INavigationService Navigation
		{
			get
			{
				return _navigation;
			}
			set
			{
                _navigation = value;
				OnPropertyChanged(nameof(Navigation));
			}
		}

		public ICommand NavigationHomeView { get; private set; }
		public ICommand NavigationSettingView { get; private set; }

        public MainViewModel(INavigationService navigation)
		{
			Navigation = navigation;

			NavigationHomeView = new RelayCommand(o => Navigation.NavigationTo<HomeViewModel>());
            NavigationSettingView = new RelayCommand(o => Navigation.NavigationTo<SettingViewModel>());
        }

	}
}

using NavigationDI.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

namespace NavigationDI.Service
{
    public interface INavigationService {
        ViewModelBase CurrentView { get; }

        public void NavigationTo<T>() where T : ViewModelBase;
    }


    public class NavigationService : ObservationObject, INavigationService
    {

        private Func<Type, ViewModelBase> _viewModelFactory;

        private ViewModelBase _currentView;

        public ViewModelBase CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                OnPropertyChanged(nameof(ViewModelBase));
            }
        }

        public NavigationService(Func<Type, ViewModelBase> viewModelFactory)
        {
            _viewModelFactory = viewModelFactory;
        }

        public void NavigationTo<TViewMode>() where TViewMode : ViewModelBase
        {
            ViewModelBase viewModel = _viewModelFactory?.Invoke(typeof(TViewMode));
        }
    }
}

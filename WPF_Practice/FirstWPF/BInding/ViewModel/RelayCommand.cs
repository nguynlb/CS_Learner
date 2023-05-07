using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BInding.ViewModel
{
    public class RelayCommand : ICommand
    {
        private readonly Action<object> _executeAction;
        private readonly Predicate<object> _canExecute;

        public RelayCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
        }


        public RelayCommand(Action<object> executeAction, Predicate<object> canExecute)
        {
            _executeAction = executeAction;
            _canExecute = canExecute;
        }

        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }

        public bool CanExecute(object? parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

        public void Execute(object? parameter)
        {
            _executeAction?.Invoke(parameter);
        }
    }
}

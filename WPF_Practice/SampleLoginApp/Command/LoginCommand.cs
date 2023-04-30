using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace SampleLoginApp.Command
{
    internal class LoginCommand : ICommand
    {
        // CallBack Execute
        // Event Listener
        private Action<object> _executeAction;

        public LoginCommand(Action<object> executeAction)
        {
            _executeAction = executeAction;
        }


        public bool CanExecute(object? parameter) => true;
        public event EventHandler? CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested += value; }
        }


        public void Execute(object? parameter)
        {
            _executeAction?.Invoke(parameter);
        }
    }
}

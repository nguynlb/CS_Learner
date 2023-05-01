//using System;
//using System.CodeDom;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Input;

//namespace CloneApp.Core
//{
//    public class ViewModelCommand : ICommand
//    {
//        private Action<object> _executeAction;

//        private Predicate<object> _canExecute;

//        public ViewModelCommand(Action<object> executeAction)
//        {
//            _executeAction = executeAction;
//        }

//        public event EventHandler? CanExecuteChanged
//        {
//            add { CommandManager.RequerySuggested += value; }
//            remove { CommandManager.RequerySuggested -= value; }
//        }

//        public bool CanExecute(object? parameter) => true;

//        public void Execute(object? parameter) => _executeAction(parameter);
//    }
//}

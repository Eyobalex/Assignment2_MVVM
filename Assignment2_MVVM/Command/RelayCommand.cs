using System;
using System.Windows.Input;

namespace Assignment2_MVVM.Command
{
    public class RelayCommand : ICommand
    {
        Action<object> executeAction;
        private Func<object, bool> canExecute;
        private bool canExecuteCache;

        public RelayCommand(Action<object> executeAction, Func<object, bool> canExecute, bool canExecuteCache)
        {
            this.canExecute = canExecute;
            this.executeAction = executeAction;
            this.canExecuteCache = canExecuteCache;
        }

        public bool CanExecute(object parameter)
        {
            if (canExecute == null)
            {
                return true;
            }
            else
            {
                return canExecute(parameter);
            }
        }
        public event EventHandler CanExecuteChanged
        {
            add
            {
//                if (!canExecuteCache)
//                {
                    CommandManager.RequerySuggested += value;
//                }
            }
            remove
            {
//                if (!canExecuteCache)
//                {
                    CommandManager.RequerySuggested += value;
//                }
            }
        }

        public void Execute(object parameter)
        {
            executeAction(parameter);
        }
    }
}
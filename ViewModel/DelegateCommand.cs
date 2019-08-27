using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace VideoEssayBingo.ViewModel
{
    public class DelegateCommand : ICommand
    {
        private readonly Action<object> action;
        private readonly Func<object, bool> canExecute;

        public DelegateCommand(Action<object> executeCommand)
        {
            action = executeCommand;
            canExecute = null;
        }

        public DelegateCommand(Action<object> executeCommand, Func<object, bool> canExecuteCommand)
        {
            action = executeCommand;
            canExecute = canExecuteCommand;
        }

        public void Execute(object parameter) => action(parameter);

        public bool CanExecute(object parameter) => canExecute?.Invoke(parameter) ?? true;

        public event EventHandler CanExecuteChanged
        {
            add { CommandManager.RequerySuggested += value; }
            remove { CommandManager.RequerySuggested -= value; }
        }
    }
}

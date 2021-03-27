using System.Text;
using System.Collections.Generic;
using System.Windows.Input;
using System;

namespace newdb.Infrastructure.Commands
{
    internal abstract class Command : ICommand
    {
        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public abstract bool CanExecute(object parameter);

        public abstract void Execute(object parameter);

    }
}

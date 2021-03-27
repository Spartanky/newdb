using System.Windows;
using newdb.ViewModel.Commands.Base;

namespace newdb.ViewModel.Commands
{
    class CloseAppCommand : Command
    {
        public override bool CanExecute(object parameter) => true;
        public override void Execute(object parameter) => Application.Current.Shutdown();
    }
}

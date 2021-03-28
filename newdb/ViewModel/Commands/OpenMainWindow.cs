using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using newdb.View;
using newdb.ViewModel.Commands.Base;
using newdb.View.WindowView;

namespace newdb.ViewModel.Commands
{
    class OpenMainWindow:Command
    {
        public override bool CanExecute(object parameter) => true;

        public override void Execute(object parameter) => OpenMainWindowMethod();

        public void OpenMainWindowMethod()
        {
            MainWindow OpenWindow = new MainWindow();
            OpenWindow.Owner = Application.Current.MainWindow;
            OpenWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            OpenWindow.ShowDialog();
        }
    }
}

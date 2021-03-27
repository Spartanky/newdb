using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using newdb.Infrastructure.Commands;

namespace newdb.ViewModel
{
    class LoginViewModel:ViewModel
    {
        #region Commands
        public ICommand CloseAppCommand { get; }

        private bool CanCloseAppCommandExecute(object p) => true;
        private void OnCloseAppCommandExecuted(object p)
        {
            Application.Current.Shutdown();
        }
        #endregion

        public LoginViewModel()
        {
            CloseAppCommand = new RelayCommand(OnCloseAppCommandExecuted, CanCloseAppCommandExecute);
        }

    }
}

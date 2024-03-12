using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace CPS
{
    public class Class2
    {
        private RelayCommand _exitCommand;

        public RelayCommand ExitCommand
        {
            get
            {
                return _exitCommand ?? new RelayCommand(obj =>
                {
                    MessageBoxResult Result = MessageBox.Show("Закрыть окно?", "Уведомление", MessageBoxButton.YesNo);
                    if (Result == MessageBoxResult.Yes)
                    {
                        Application.Current.Shutdown();
                    }
                    else if (Result == MessageBoxResult.No)
                    {
                        //
                    }
                });
            }
        }

        public RelayCommand MinimizeCommand =>
            new RelayCommand(obj => Application.Current.MainWindow.WindowState = WindowState.Minimized);

    }

    public class RelayCommand : ICommand
    {
        private Action<object> execute;
        private Func<object, bool> canExecute;

        public event EventHandler CanExecuteChanged
        {
            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            this.execute = execute;
            this.canExecute = canExecute;
        }

        public bool CanExecute(object parameter) => this.canExecute == null || this.canExecute(parameter);

        public void Execute(object parameter) => this.execute(parameter);
    }
}

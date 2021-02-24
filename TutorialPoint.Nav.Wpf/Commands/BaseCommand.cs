using System;
using System.Windows.Input;

namespace TutorialPoint.Nav.Wpf.Commands
{
    public class BaseCommand<T> : ICommand
    {
        private readonly Action<T> _targetExecuteMethod;
        private readonly Func<T, bool> _targetCanExecuteMethod;

        public BaseCommand(Action<T> executeMethod)
        {
            _targetExecuteMethod = executeMethod;
        }

        public BaseCommand(Action<T> executeMethod, Func<T, bool> canExecuteMethod)
        {
            _targetExecuteMethod = executeMethod;
            _targetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        #region ICommand Members

        bool ICommand.CanExecute(object parameter)
        {

            if (_targetCanExecuteMethod != null)
            {
                T tparm = (T)parameter;
                return _targetCanExecuteMethod(tparm);
            }
            return _targetExecuteMethod != null;
        }

        // Beware - should use weak references if command instance lifetime is
        // longer than lifetime of UI objects that get hooked up to command

        // Prism commands solve this in their implementation

        public event EventHandler CanExecuteChanged = delegate { };

        void ICommand.Execute(object parameter)
        {
            _targetExecuteMethod?.Invoke((T)parameter);
        }

        #endregion
    }
}

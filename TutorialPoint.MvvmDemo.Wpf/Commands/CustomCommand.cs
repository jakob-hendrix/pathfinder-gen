using System;
using System.Windows.Input;

namespace TutorialPoint.MvvmDemo.Wpf.Commands
{
    public class CustomCommand : ICommand
    {
        private readonly Action _targetExecuteMethod;
        private readonly Func<bool> _targetCanExecuteMethod;

        public CustomCommand(Action executeMethod)
        {
            _targetExecuteMethod = executeMethod;
        }

        public CustomCommand(Action executeMethod, Func<bool> canExecuteMethod)
        {
            _targetExecuteMethod = executeMethod;
            _targetCanExecuteMethod = canExecuteMethod;
        }

        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged(this, EventArgs.Empty);
        }

        public bool CanExecute(object parameter)
        {
            if (_targetCanExecuteMethod != null)
            {
                return _targetCanExecuteMethod();
            }
            return _targetExecuteMethod != null;
        }

        public void Execute(object parameter) => _targetExecuteMethod?.Invoke();

        public event EventHandler CanExecuteChanged = delegate { };
    }
}

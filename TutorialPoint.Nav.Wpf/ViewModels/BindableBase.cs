using System.ComponentModel;
using System.Runtime.CompilerServices;
using TutorialPoint.Nav.Wpf.Annotations;

namespace TutorialPoint.Nav.Wpf.ViewModels
{
    public class BindableBase : INotifyPropertyChanged
    {
        /// <summary>
        /// Wrapper for throwing PropertyChangedEvents when the given property is changed.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="property"></param>
        /// <param name="value"></param>
        /// <param name="propertyName"></param>
        protected virtual void SetProperty<T>(ref T property, T value, [CallerMemberName] string propertyName = null)
        {
            if (!Equals(property, value))
            {
                property = value;
                OnPropertyChanged(propertyName);
                //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate {};
    }
}

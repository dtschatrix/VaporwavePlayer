using System;
using PropertyChanged;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace VaporwavePlayer.Core
{
    /// <summary>
    /// A base view model that fires Property Changed events as needed
    /// </summary>
    
    public class BaseViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The event that is fired when any child property changes its value
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };

        /// <summary>
        /// Call this to fire a <see cref="PropertyChanged"/> event
        /// </summary>
        /// <param name="name"  ></param>
        public void OnPropertyChanged(string name)
        {
            PropertyChanged(this, new PropertyChangedEventArgs(name));
        }

        #region Command Helpers
        /// <summary>
        /// Runs a command if a flag not set
        /// </summary>
        /// <param name="updatingFlag"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        protected async Task RunCommand(Expression<Func<bool>> updatingFlag, Func<Task> action) 
        {
            //Check if flag property is true(function is running)
            if (updatingFlag.GetPropertyValue())
                return;

            //Set the property flag to true to indicate we are running

            updatingFlag.SetPropertyValue(true);

            try
            {
                await action();
            }
            finally
            {
                updatingFlag.SetPropertyValue(false);
            }

        }

        #endregion
    }
}
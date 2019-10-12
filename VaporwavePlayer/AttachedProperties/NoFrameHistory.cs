using System.Windows;
using System.Windows.Controls;

namespace VaporwavePlayer
{
    /// <summary>
    /// Class which clears history of navigation and hide navigation bar
    /// </summary>
    public class NoFrameHistory : BaseAttachedProperty<NoFrameHistory, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            if (sender is Frame frame)
            {
                frame.NavigationUIVisibility = System.Windows.Navigation.NavigationUIVisibility.Hidden;

                frame.Navigated += (ss, ee) => ((Frame) ss).NavigationService.RemoveBackEntry();
            }
        }
    }

}

using System.Windows;
using System.Windows.Controls;

namespace VaporwavePlayer
{


    /// <summary>
    /// The focused property for text 
    /// </summary>

    public class IsFocusedProperty : BaseAttachedProperty<IsFocusedProperty, bool>
    {
        public override void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
        {
            //If we dont have a control, return
            if (!(sender is Control control))
                return;

            control.Loaded += (o, args) => control.Focus();
        }
    }

}

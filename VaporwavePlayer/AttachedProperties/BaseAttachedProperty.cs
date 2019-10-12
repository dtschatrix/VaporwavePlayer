using System;
using System.Windows;

namespace VaporwavePlayer
{
    /// <summary>
    /// base attached property 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <typeparam name="Parent">The parent class to be the attached property</typeparam>
    /// <typeparam name="Property">The type of this attached property</typeparam>
    public abstract class BaseAttachedProperty<Parent, Property>
        where Parent :  new()
    {

        #region Public Events

        public event Action<DependencyObject, DependencyPropertyChangedEventArgs> ValueChanged = (sender, e) => { };

        public event Action<DependencyObject, object> ValueUpdated = (sender, value) => { };
        #endregion

        #region Public Properties

        public static Parent Instance { get;  private set; } = new Parent();

        #endregion

        #region Attached Property Definintions
        /// <summary>
        /// The attached property for this class
        /// </summary>
        public static readonly DependencyProperty ValueProperty = 
            DependencyProperty.RegisterAttached("Value",
                typeof(Property),
                typeof(BaseAttachedProperty<Parent, Property>),
                new UIPropertyMetadata(
                    default(Property),
                    OnValuePropertyChanged,
                    OnValuePropertyUpdated));
        /// <summary>
        /// The callback event when <see cref="ValueProperty"/> is changed
        /// </summary>
        /// <param name="d">The UI element had it's property changed</param>
        /// <param name="e">The arguments for the event</param>
        private static void OnValuePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            (Instance as BaseAttachedProperty<Parent, Property>)?.OnValueChanged(d, e);

            //Call event listeners 
            (Instance as BaseAttachedProperty<Parent, Property>)?.ValueChanged(d, e);
        }
        private static object OnValuePropertyUpdated(DependencyObject d, object value)
        {
            (Instance as BaseAttachedProperty<Parent, Property>)?.OnValueUpdated(d, value);

            //Call event listeners 
            (Instance as BaseAttachedProperty<Parent, Property>)?.ValueUpdated(d, value);

            return value;
        }
        /// <summary>
        /// Gets the value of attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <returns></returns>
        public static Property GetValue(DependencyObject d) => (Property) d.GetValue(ValueProperty);
        /// <summary>
        /// Sets the attached property
        /// </summary>
        /// <param name="d">The element to get the property from</param>
        /// <param name="value">The value to set property to</param>
        public static void SetValue(DependencyObject d, Property value) => d.SetValue(ValueProperty, value);

        #endregion

        #region Event Methods
        /// <summary>
        /// This method thas is called when any attached property of this type is changed
        /// </summary>
        /// <param name="sender">The UI element that this property was changed for</param>
        /// <param name="e">The arguments for this event</param>
        public virtual void OnValueChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e) { }

        public virtual void OnValueUpdated(DependencyObject sender, object value) {}
        #endregion
    }

    
}

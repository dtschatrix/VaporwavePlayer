using System.Windows;


namespace VaporwavePlayer
{

    /// <summary>
    /// A base class to run any animation when a boolean is true
    /// and a reverse is false
    /// </summary>
    /// <typeparam name="Parent"></typeparam>
    public abstract class AnimateBaseProperty<Parent> : BaseAttachedProperty<Parent, bool>
    where Parent : BaseAttachedProperty<Parent, bool>, new()
    {
        #region Public Properties
        /// <summary>
        /// first time running animation
        /// </summary>
        public bool FirstLoad { get; set; } = true;

        #endregion

        public override void OnValueUpdated(DependencyObject sender, object value)
        {
            if (!(sender is FrameworkElement element))
                return;

            //Don't fire if the value doesn't changed
            if (sender.GetValue(ValueProperty) == value && !FirstLoad)
                return;
            // On first load 
            if (FirstLoad)
            {
                //Create a single self-unhookable event
                RoutedEventHandler onLoaded = null;
                
                onLoaded = (ss, ee) =>
                {
                    //Unhook ourselves
                    element.Loaded -= onLoaded;
                    //Do animation
                    DoAnimation(element, (bool) value);
                    //No longer first load
                    FirstLoad = false;
                };
                //Hook into the loaded event
                element.Loaded += onLoaded;
            }
            else
            {
                DoAnimation(element, (bool) value);
            }

        }

        /// <summary>
        /// The animation fired then element changed
        /// </summary>
        /// <param name="element"></param>
        /// <param name="value"></param>
        protected virtual void DoAnimation(FrameworkElement element, bool value) { }

    }

    public class AnimateSlideInFromLeftProperty : AnimateBaseProperty<AnimateSlideInFromLeftProperty>
    {

        protected override async void DoAnimation(FrameworkElement element, bool value)
        {

            if (value)
            {
                await element.SlideAndFadeInFromLeft(FirstLoad ? 0: 0.3f,keepMargin:false);

            }
            else
            {
                await element.SlideAndFadeOutToLeft(FirstLoad ? 0 : 0.3f, keepMargin: false);
            }

        }


    }
}

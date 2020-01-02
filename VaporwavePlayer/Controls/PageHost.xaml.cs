using System.ComponentModel;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using VaporwavePlayer.Core;


namespace VaporwavePlayer
{
    /// <summary>
    /// Interaction logic for PageHost.xaml
    /// </summary>
    public partial class PageHost : UserControl
    {

        #region Consturctors

        public PageHost()
        {
            InitializeComponent();

            // If we are in DesignMode, show the current page
            // as the dependency property does not fire
           if (DesignerProperties.GetIsInDesignMode(this))
                NewPage.Content = (BasePage)new ApplicationPageValueConverter().Convert(IoC.Get<ApplicationViewModel>().CurrentPage);
        }

        #endregion


        /// <summary>
        /// The current page to show in the host page
        /// </summary>
        public BasePage CurrentPage
        {
            get => (BasePage)GetValue(CurrentPageProperty);
            set => SetValue(CurrentPageProperty, value);
        }

        
        // Using a DependencyProperty as the backing store for MyProperty.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty CurrentPageProperty =
            DependencyProperty.Register(
                nameof(CurrentPage), 
                typeof(BasePage),
                typeof(PageHost),
                new UIPropertyMetadata(CurrentPagePropertyChanged));

        public static readonly DependencyProperty CurrentPageViewModelProperty = DependencyProperty.Register(
            "PropertyType", typeof(BaseViewModel), typeof(PageHost), new UIPropertyMetadata());
            
        public BaseViewModel CurrentPageViewModel
        {
            get => (BaseViewModel) GetValue(CurrentPageViewModelProperty);
            set => SetValue(CurrentPageViewModelProperty, value);
        }




        #region Property Changed Events

        private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            // Get the frames
            var newPageFrame = (d as PageHost)?.NewPage;
            var oldPageFrame = (d as PageHost)?.OldPage;

            // Store the current page content as the old page
            var oldPageContent = newPageFrame.Content;

            // Remove current page from new page frame
            newPageFrame.Content = null;

            // Move the previous page into the old page frame
          // Animate out previous page when the Loaded event fires
                // right after this call due to moving frames
                if (oldPageContent is BasePage oldPage)
                {
                    // Tell old page to animate out
                    oldPage.ShouldAnimateOut = true;

                    // Once it is done, remove it
                    Task.Delay((int) (oldPage.SlideSeconds * 1000)).ContinueWith((t) =>
                    {
                        // Remove old page
                        if (Application.Current.Dispatcher != null)
                            Application.Current.Dispatcher.Invoke(() => oldPageFrame.Content = null);
                    });
                }
            

            // Set the new page content
            newPageFrame.Content = e.NewValue;
        }


        #endregion
       
    }
}

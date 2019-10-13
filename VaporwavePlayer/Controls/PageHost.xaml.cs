using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;


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
            DependencyProperty.Register(nameof(CurrentPage), typeof(BasePage), typeof(PageHost), new UIPropertyMetadata(CurrentPagePropertyChanged));

        


        #region Property Changed Events

        private static void CurrentPagePropertyChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            //get the frames
            var newPageFrame = (d as PageHost)?.NewPage;
            var oldPageFrame = (d as PageHost)?.OldPage;

            //Store the current content on page
            var oldPageContent = newPageFrame.Content;

            //Remove current page from new page
            newPageFrame.Content = null;

            //Move the previous page into old page
            oldPageFrame.Content = oldPageContent;

            if (oldPageContent is BasePage oldPage)
                oldPage.ShouldAnimateOut = true;

            newPageFrame.Content = e.NewValue;
        }


        #endregion
       
    }
}

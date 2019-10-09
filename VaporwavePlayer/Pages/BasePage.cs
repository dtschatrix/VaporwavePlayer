using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;
using VaporwavePlayer.Core;

namespace VaporwavePlayer
    {
        public class BasePage<VM> : Page
            where VM : BaseViewModel, new()

        {

        #region Private Members

        private VM mViewModel;

        #endregion

        #region Public Properties

        public PageAnimation PageLoadAnimation { get; set; } = PageAnimation.SlideAndFadeInFromRight;

        public PageAnimation PageUnloadAnimation { get; set; } = PageAnimation.SlideAndFadeOutToLeft;

        public float SlideSeconds { get; set; } = 0.8f;

            public VM ViewModel
            {
                get => ViewModel;
                set
                {
                    // If nothing has changed => return
                    if (mViewModel == value)
                        return;

                    mViewModel = value;
                    //set the data Context
                    this.DataContext = mViewModel;
                }
            }

        #endregion

        #region Constructors

        /// <summary>
        /// Default constructor
        /// </summary>
        public BasePage()
        {
            if (this.PageLoadAnimation != PageAnimation.None)
                this.Visibility = Visibility.Collapsed;
            this.Loaded += BasePage_Loaded;
            this.ViewModel = new VM();
            }



        /// <summary>
        /// Once the page is loaded perform any required animation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void BasePage_Loaded(object sender, RoutedEventArgs e)
        {
            await AnimateIn();
        }

        public async Task AnimateIn()
        {
            if (this.PageLoadAnimation == PageAnimation.None)
                return;

            switch (this.PageLoadAnimation)
            {
                case PageAnimation.SlideAndFadeInFromRight:
                    //Start the animation
                    await this.SlideAndFadeInFromRight(this.SlideSeconds);

                    break;

            }
        }

        public async Task AnimateOut()
        {
            if (this.PageUnloadAnimation == PageAnimation.None)
                return;

            switch (this.PageUnloadAnimation)
            {
                case PageAnimation.SlideAndFadeOutToLeft:
                    //Start the animation
                    await this.SlideAndFadeOutToLeft(this.SlideSeconds);

                    break;

            }
        }


        #endregion


        }
    }

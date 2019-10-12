using System;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Animation;

namespace VaporwavePlayer
{
    /// <summary>
    /// Helpers to animate pages
    /// </summary>
   public static class FrameworkElementAnimations
    {
        /// <summary>
        /// Slides an element in from the right
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            //Create the storyboard
            var storyboardAnimation = new Storyboard();

            //Add slide from right to animation
            storyboardAnimation.AddSlideFromRight(seconds: seconds,offset: element.ActualWidth,keepMargin: keepMargin);
            //Add fade in animation
            storyboardAnimation.AddFadeIn(seconds: seconds);

            //Start animation
            storyboardAnimation.Begin(element);
            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait it for finish
            await Task.Delay((int)(seconds * 1000));
        }
        /// <summary>
        /// Slides an element in from the right
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="keepMargin"></param>
        /// <returns></returns>
        public static async Task SlideAndFadeToFromRight(this FrameworkElement element, float seconds, bool keepMargin = true)
        {
            //Create the storyboard
            var storyboardAnimation = new Storyboard();

            //Add slide from right to animation
            storyboardAnimation.AddSlideToRight(seconds: seconds, offset: element.ActualWidth,keepMargin: keepMargin);
            //Add fade in animation
            storyboardAnimation.AddFadeIn(seconds: seconds);

            //Start animation
            storyboardAnimation.Begin(element);
            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait it for finish
            await Task.Delay((int)(seconds * 1000));
        }
        /// <summary>
        /// Slides an element out to left
        /// </summary>
        /// <param name="element">The page to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            //Create the storyboard
            var storyboardAnimation = new Storyboard();

            //Add slide from right to animation
            storyboardAnimation.AddSlideToLeft(seconds: seconds, offset: element.ActualWidth, keepMargin: keepMargin);
            //Add fade in animation
            storyboardAnimation.AddFadeOut(seconds: seconds);

            //Start animation
            storyboardAnimation.Begin(element);
            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait it for finish
            await Task.Delay((int)(seconds * 1000));
        }


        /// <summary>
        /// Slides an element in from the left
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromLeft(this FrameworkElement element, float seconds = 0.3f, bool keepMargin = true)
        {
            //Create the storyboard
            var storyboardAnimation = new Storyboard();

            //Add slide from right to animation
            storyboardAnimation.AddSlideFromLeft(seconds: seconds, offset: element.ActualWidth, keepMargin: keepMargin);
            //Add fade in animation
            storyboardAnimation.AddFadeIn(seconds: seconds);

            //Start animation
            storyboardAnimation.Begin(element);
            //Make page visible
            element.Visibility = Visibility.Visible;

            //Wait it for finish
            await Task.Delay((int)(seconds * 1000));
        }
    }
}

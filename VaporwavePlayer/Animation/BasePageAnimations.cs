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
   public static class BasePageAnimations
    {
        /// <summary>
        /// Slides and fade from right animation
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeInFromRight(this Page page, float seconds)
        {
            //Create the storyboard
            var storyboardAnimation = new Storyboard();

            //Add slide from right to animation
            storyboardAnimation.AddSlideFromRight(seconds: seconds,offset: page.WindowWidth,decelerationRatio:.6f);
            //Add fade in animation
            storyboardAnimation.AddFadeIn(seconds: seconds);

            //Start animation
            storyboardAnimation.Begin(page);
            //Make page visible
            page.Visibility = Visibility.Visible;

            //Wait it for finish
            await Task.Delay((int)(seconds * 1000));
        }
        /// <summary>
        /// Slides and fade page out to the left animation
        /// </summary>
        /// <param name="page">The page to animate</param>
        /// <param name="seconds">Duration of animation</param>
        /// <returns></returns>
        public static async Task SlideAndFadeOutToLeft(this Page page, float seconds)
        {
            //Create the storyboard
            var storyboardAnimation = new Storyboard();

            //Add slide from right to animation
            storyboardAnimation.AddSlideToLeft(seconds: seconds, offset: page.WindowWidth, decelerationRatio: .6f);
            //Add fade in animation
            storyboardAnimation.AddFadeOut(seconds: seconds);

            //Start animation
            storyboardAnimation.Begin(page);
            //Make page visible
            page.Visibility = Visibility.Visible;

            //Wait it for finish
            await Task.Delay((int)(seconds * 1000));
        }

    }
}

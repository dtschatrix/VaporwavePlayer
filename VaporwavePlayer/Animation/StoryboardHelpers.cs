using System;
using System.Windows;
using System.Windows.Media.Animation;

namespace VaporwavePlayer
{
    /// <summary>
    /// Animation helpers for <see cref="StoryBoard"/>
    /// </summary>
    public static class StoryboardHelpers
    {
        /// <summary>
        /// Adds a slide from right in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="offset">The distance from right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration    </param>
        /// <param name="keepMargin">keep the element at the same width during animation</param>
        public static void AddSlideFromRight(this Storyboard storyboard, float seconds, double offset,
            float decelerationRatio = 0.6f, bool keepMargin = true)
        {

            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio

            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);

        }
        /// <summary>
        /// Adds a slide from left in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="offset">The distance from right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration    </param>
        public static void AddSlideToLeft(this Storyboard storyboard, float seconds, double offset,
            float decelerationRatio = 0.6f, bool keepMargin = true)
        {

            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                DecelerationRatio = decelerationRatio

            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// Adds a slide from left in animation to the storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="offset">The distance from right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration    </param>
        public static void AddSlideFromLeft(this Storyboard storyboard, float seconds, double offset,
            float decelerationRatio =0.6f, bool keepMargin = true)
        {

            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(-offset, 0, keepMargin ? offset : 0, 0),
                To = new Thickness(0),
                DecelerationRatio = decelerationRatio

            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);

        }

        public static void AddSlideToRight(this Storyboard storyboard, float seconds, double offset,
            float decelerationRatio = 0.6f, bool keepMargin = true)
        {

            var animation = new ThicknessAnimation
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = new Thickness(0),
                To = new Thickness(keepMargin ? offset : 0, 0, -offset, 0),
                DecelerationRatio = decelerationRatio

            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Margin"));
            storyboard.Children.Add(animation);

        }

        /// <summary>
        /// Adds a fade in animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="offset">The distance from right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration    </param>
        public static void AddFadeIn(this Storyboard storyboard, float seconds) { 

            var animation = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 0,
                To = 1
                
            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);

        }
        /// <summary>
        /// Adds a fade out in animation to storyboard
        /// </summary>
        /// <param name="storyboard">The storyboard to add animation</param>
        /// <param name="seconds">Duration of animation</param>
        /// <param name="offset">The distance from right to start from</param>
        /// <param name="decelerationRatio">The rate of deceleration    </param>
        public static void AddFadeOut(this Storyboard storyboard, float seconds)
        {

            var animation = new DoubleAnimation()
            {
                Duration = new Duration(TimeSpan.FromSeconds(seconds)),
                From = 1,
                To = 0

            };
            //Set the target property name
            Storyboard.SetTargetProperty(animation, new PropertyPath("Opacity"));
            storyboard.Children.Add(animation);

        }
        





    }
}

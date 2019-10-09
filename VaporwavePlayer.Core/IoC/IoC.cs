using System;
using Ninject;

namespace VaporwavePlayer.Core
{
    public static class IoC
    {
        #region Public Properties
        /// <summary>
        /// The kernel for IoC container
        /// </summary>
        public static IKernel Kernel { get; private set; } = new StandardKernel();
        #endregion

        /// <summary>
        /// Setup for IoC kernel
        /// </summary>

       
        public static void Setup()
        {
            BindViewModels();

        }

        private static void BindViewModels()
        {
            //Bind to a single instance of application view model
            Kernel.Bind<ApplicationViewModel>().ToConstant(new ApplicationViewModel());
        }
        public static T Get<T>()
        {
            return Kernel.Get<T>();
        }

    }
}

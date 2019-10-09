using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using VaporwavePlayer.Core;

namespace VaporwavePlayer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Custom startup because of IoC
        /// </summary>
        /// <param name="e"></param>
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);


            IoC.Setup();

            //show the main window

            Current.MainWindow = new MainWindow();
            Current.MainWindow.Show();

        }
    }
}

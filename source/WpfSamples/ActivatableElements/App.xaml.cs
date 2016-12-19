//-----------------------------------------------------------------------
// Copyright 2014 Tobii Technology AB. All rights reserved.
//-----------------------------------------------------------------------

namespace ActivatableElements
{
    using System;
    using System.Windows;
    using EyeXFramework;
    using EyeXFramework.Wpf;
    using Tobii.EyeX.Framework;

    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {

       // System.IO.StreamWriter file;

        private WpfEyeXHost _eyeXHost;

        public WpfEyeXHost EyeXHost
        {
            get { return _eyeXHost; }
        }

        public App()
        {
            // file = new System.IO.StreamWriter("c:\\testdata\\test.txt", true);
            _eyeXHost = new WpfEyeXHost();
            _eyeXHost.Start();
            
            // Create a data stream: lightly filtered gaze point data.
            // Other choices of data streams include EyePositionDataStream and FixationDataStream.
           /* using (var lightlyFilteredGazeDataStream = _eyeXHost.CreateGazePointDataStream(GazePointDataMode.LightlyFiltered))
            {
                lightlyFilteredGazeDataStream.Next += gazeCallback;// Console.WriteLine("Gaze point at ({0:0.0}, {1:0.0}) @{2:0}  ", e.Timestamp, e.X, e.Y);
            }*/

        }

       /* private void gazeCallback(object sender, GazePointEventArgs e)
        {
            Console.WriteLine(e.X);
        }*/

        protected override void OnExit(ExitEventArgs e)
        {
            base.OnExit(e);
            _eyeXHost.Dispose();
            //file.Close();
        }


       /* private void log(double x, double y, double timestamp)
        {
            Console.WriteLine("In Logfunc");
            file.WriteLine("Gaze point at ({0:0.0}, {1:0.0}) @{2:0}", x, y, timestamp);

        }*/

        /*private void gazeCallback(object s, EyeXFramework.GazePointEventArgs e)
        {
             //RunOnMainThread(() =>
             //{
             Console.WriteLine("bin drin");
                 c
             //});
         }*/

        private static void RunOnMainThread(Action action)
        {
            if (Application.Current != null)
            {
                Application.Current.Dispatcher.BeginInvoke(action);
            }
        }
    }


}

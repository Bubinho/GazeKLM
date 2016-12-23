//-----------------------------------------------------------------------
// Copyright 2014 Tobii Technology AB. All rights reserved.
//-----------------------------------------------------------------------

namespace MinimalGazeDataStream
{
    using EyeXFramework;
    using System;
    using System.IO;
    using Tobii.EyeX.Framework;

    public static class Program
    {
        static double timerInMilli = 0;
        static StreamWriter sw;

        private static void gazeCallback(object s, EyeXFramework.GazePointEventArgs e)
        {
            
            if (timerInMilli == 0)
            {
                sw.WriteLine("timestamp;x;y;region;buchstabe");
                timerInMilli = e.Timestamp;
            }
            try {

                //Writes the method name with the exception and writes the exception underneath
                sw.WriteLine(String.Format("{0};{1};{2}", e.Timestamp - timerInMilli, e.X, e.Y));
                
            }
            catch (IOException)
            {

            }


        }
        public static void Main(string[] args)
        {
            using (var eyeXHost = new EyeXHost())
            {
                // Create a data stream: lightly filtered gaze point data.
                // Other choices of data streams include EyePositionDataStream and FixationDataStream.
                using (var lightlyFilteredGazeDataStream = eyeXHost.CreateGazePointDataStream(GazePointDataMode.LightlyFiltered))
                {
                    // Start the EyeX host.
                    eyeXHost.Start();

                    //check if a log file exists and create a new with actal ending if not
                    int x = 0;
                    while (File.Exists(@"..\..\..\logs\log" + x + ".txt"))
                    {
                        x++; 
                    }
                    FileStream fs = File.Create(@"..\..\..\logs\log" + x + ".txt");
                    fs.Close();

                    sw = new StreamWriter(
                        new System.IO.FileStream(
                            @"..\..\..\logs\log" + x + ".txt",
                            System.IO.FileMode.Append,
                            FileAccess.Write,
                            FileShare.ReadWrite
                        )
                    );

                    // Write the data to the console.
                    lightlyFilteredGazeDataStream.Next += gazeCallback;//(s, e) => //Console.WriteLine("Gaze point at ({0:0.0}, {1:0.0}) @{2:0}", e.X, e.Y, e.Timestamp);

                    // Let it run until a key is pressed.
                    Console.WriteLine("Listening for gaze data, press any key to exit...");
                    Console.In.Read();
                    sw.Close();
                }
            }
        }
    }
}

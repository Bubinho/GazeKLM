/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ActivatableElements
{
    using EyeXFramework;


    static class Logger
    {
        public static void log()
        {
            using (var eyeXHost = new EyeXHost())
            {
                System.IO.StreamWriter file = new System.IO.StreamWriter("c:\\test.txt", true);
                // Create a data stream: lightly filtered gaze point data.
                // Other choices of data streams include EyePositionDataStream and FixationDataStream.
                using (var lightlyFilteredGazeDataStream = eyeXHost.CreateGazePointDataStream(GazePointDataMode.LightlyFiltered))
                {
                    // Start the EyeX host.
                    eyeXHost.Start();


                    // Write the data to the console.
                    lightlyFilteredGazeDataStream.Next += (s, e) => file.WriteLine("@{0:0} Gaze point at ({1:0.0}, {2:0.0}) ", e.Timestamp, e.X, e.Y); //Console.WriteLine("@{0:0} Gaze point at ({1:0.0}, {2:0.0}) ", e.Timestamp,  e.X, e.Y);

                }
            }
            
           // file.Close();

        }
    }
}*/

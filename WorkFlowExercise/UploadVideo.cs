using System;

namespace WorkFlowExercise
{
    public class UploadVideo : ITask
    {
        public void Execute()
        {
            Console.WriteLine("1-Upload a video to a cloud storage");
        }
    }
}
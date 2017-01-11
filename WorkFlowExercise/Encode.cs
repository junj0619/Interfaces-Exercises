using System;

namespace WorkFlowExercise
{
    public class Encode : ITask
    {
        public void Execute()
        {
            Console.WriteLine("2-Call a web service provided by a third-party video encoding service to tell them you have a video ready for encoding.");
        }
    }
}
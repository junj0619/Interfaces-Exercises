using System;

namespace WorkFlowExercise
{
    public class SendEmail:ITask
    {
        public void Execute()
        {
            Console.WriteLine("3-Send an email to the owner of the video notifying them that the video started processing.");
        }
    }
}
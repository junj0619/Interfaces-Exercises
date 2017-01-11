using System;

namespace WorkFlowExercise
{
    public class ChangeStatus:ITask
    {
        public void Execute()
        {
            Console.WriteLine("4-Change the status of the video record in the database to “Processing”.");
        }
    }
}
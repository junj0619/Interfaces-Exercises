namespace WorkFlowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var workFlow = new WorkFlow();
            workFlow.Add(new UploadVideo());
            workFlow.Add(new Encode());
            workFlow.Add(new SendEmail());
            workFlow.Add(new ChangeStatus());

            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(workFlow);
        }
    }
}

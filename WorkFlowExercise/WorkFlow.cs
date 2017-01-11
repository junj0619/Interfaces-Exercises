using System.Collections.Generic;

namespace WorkFlowExercise
{
    public class WorkFlow : IWorkFlow
    {
        private readonly List<ITask> _workFlowList;

        public WorkFlow()
        {
            _workFlowList = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _workFlowList.Add(task);
        }

        public void Remove(ITask task)
        {
            _workFlowList.Remove(task);
        }

        public IEnumerable<ITask> GetTasks()
        {
            return _workFlowList;
        }
    }
}
using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    public class WorkFlowEngine
    {
        private readonly List<ITaskExecution> _taskExecutionList;

        public WorkFlowEngine(List<ITaskExecution> taskExecutionList)
        {
            _taskExecutionList = taskExecutionList;
        }
        public void Run()
        {
            foreach (var task in _taskExecutionList)
            {
                task.Execute();
            }
        }
    }
}

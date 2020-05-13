using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<ITaskExecution> taskList = new List<ITaskExecution>();
            taskList.Add(new Download());
            taskList.Add(new Unpack());
            taskList.Add(new Install());

            var workFlowEngine = new WorkFlowEngine(taskList);
            workFlowEngine.Run();
        }
    }
}

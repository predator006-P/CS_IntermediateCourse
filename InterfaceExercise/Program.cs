using System.Collections.Generic;

namespace InterfaceExercise
{
    partial class Program
    {
        static void Main(string[] args)
        {
            var workflow = new WorkFlow();
            workflow.Add(new Download());
            workflow.Add(new Unpack());
            workflow.Add(new Install());
            workflow.Add(new Restart());

            var workFlowEngine = new WorkFlowEngine();
            workFlowEngine.Run(workflow);
        }
    }
}

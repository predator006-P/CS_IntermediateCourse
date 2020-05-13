using System;

namespace InterfaceExercise
{
    public class Install : ITaskExecution
    {
        public void Execute()
        {
            Console.WriteLine("Execute: Installing in process...");
        }
    }
}

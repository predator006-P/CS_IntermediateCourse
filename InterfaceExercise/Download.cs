using System;

namespace InterfaceExercise
{
    public class Download : ITaskExecution
    {
        public void Execute()
        {
            Console.WriteLine("Execute: Downloading...");
        }
    }
}

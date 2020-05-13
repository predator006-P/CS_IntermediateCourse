using System;

namespace InterfaceExercise
{
    public class Unpack : ITaskExecution
    {
        public void Execute()
        {
            Console.WriteLine("Execution: Unpacking in process..."); ;
        }
    }
}

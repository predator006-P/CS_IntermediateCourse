using System;

namespace InterfaceExercise
{
    public class Install : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Execute: Installing in process...");
        }
    }
}

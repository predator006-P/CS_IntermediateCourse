using System;

namespace InterfaceExercise
{
    public class Download : ITask
    {
        public void Execute()
        {
            Console.WriteLine("Execute: Downloading...");
        }
    }
}

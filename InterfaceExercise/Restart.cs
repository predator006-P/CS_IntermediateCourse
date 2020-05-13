using System;

namespace InterfaceExercise
{
    partial class Program
    {
        public class Restart : ITask
        {
            public void Execute()
            {
                Console.WriteLine("Restarting computer....");
            }
        }
    }
}

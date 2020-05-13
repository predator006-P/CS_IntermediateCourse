using System.Collections.Generic;

namespace InterfaceExercise
{
    public interface IWorkFlow
    {
        void Add(ITask task);
        void Remove(ITask task);
        public IEnumerable<ITask> GetTasks();
    }
}

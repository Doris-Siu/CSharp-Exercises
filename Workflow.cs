// See https://aka.ms/new-console-template for more information
namespace CSharp_Exercises
{

    public class Workflow : IWorkflow
    {
        private readonly List<ITask> _tasks;

        public Workflow()
        {
            _tasks = new List<ITask>();
        }

        public void Add(ITask task)
        {
            _tasks.Add(task);

        }

        public IEnumerable<ITask> GetTasks()
        {
            return _tasks;
        }

        public void Remove(ITask task)
        {
            _tasks.Remove(task);
        }
    }
}
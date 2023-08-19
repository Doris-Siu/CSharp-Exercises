namespace CSharp_Exercises
{
    public class WorkflowEngine
	{
		private List<IExecute> _workflow = new List<IExecute>();

        public void Run(IExecute obj)
		{
			_workflow.Add(obj);

foreach (var activity in _workflow)
			{
				activity.Execute();

			}
		}
	}
}


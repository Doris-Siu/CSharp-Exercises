// See https://aka.ms/new-console-template for more information
namespace CSharp_Exercises
{ 
public interface IWorkflow
{
    void Add(ITask task);
    void Remove(ITask task);
    IEnumerable<ITask> GetTasks();
    

}
}
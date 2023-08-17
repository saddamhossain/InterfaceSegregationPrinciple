namespace InterfaceSegregationPrinciple.BadDesign;

/*
 This is what ISP means:
 -> Clients should not be forced to implement any methods they don’t use. Rather than one fat interface,
    numerous little interfaces are preferred based on groups of methods with each interface serving one submodule.

 -> A class must not have to implement any interface element that is not required by the particular class.
*/


//Bad design example.
internal interface IEmployeeTasks
{
    void CreateTask();
    void CreateSubTask();
    void AssignTask();
    void WorkOnTask();
}

internal class TeamLead : IEmployeeTasks
{
    public void CreateTask()
    {
        Console.WriteLine("Task created.");
    }

    public void CreateSubTask()
    {
        Console.WriteLine("Sub Task created.");
    }

    public void AssignTask()
    {
        Console.WriteLine("Task assigned.");
    }

    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }

}

internal class Manager : IEmployeeTasks
{
    public void CreateTask()
    {
        Console.WriteLine("Task created.");
    }

    public void CreateSubTask()
    {
        Console.WriteLine("Sub Task created.");
    }

    public void AssignTask()
    {
        Console.WriteLine("Task assigned.");
    }

    // Does not work on task.
    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}

internal class Programmer : IEmployeeTasks
{
    // Cannot create task.
    public void CreateTask()
    {
        Console.WriteLine("Task created.");
    }

    // Cannot create task.
    public void CreateSubTask()
    {
        Console.WriteLine("Sub Task created.");
    }

    // Cannot assign task.
    public void AssignTask()
    {
        Console.WriteLine("Task assigned.");
    }

    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}

/*The problems are:

The Manager client has been forced to implement WorkOnTask() method although Manager does not work on task.
The Programmer client has been forced to implement CreateTask(), CreateSubTask(), and AssginTask() methods although Programmer cannot create and assign task.
*/
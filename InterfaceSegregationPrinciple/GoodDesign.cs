namespace InterfaceSegregationPrinciple.GoodDesign;

/*
 This is what ISP means:
 -> Clients should not be forced to implement any methods they don’t use. Rather than one fat interface,
    numerous little interfaces are preferred based on groups of methods with each interface serving one submodule.

 -> A class must not have to implement any interface element that is not required by the particular class.
*/

// Interfaces
internal interface ILead
{
    void CreateTask();
    void CreateSubTask();
    void AssignTask();
}

internal interface IProgrammer
{
    void WorkOnTask();
}

// Clients
internal class Manager : ILead
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
}

internal class TeamLead : ILead, IProgrammer
{
    public void CreateTask()
    {
        Console.WriteLine("Task created.");
    }

    public void CreateSubTask()
    {
        Console.WriteLine("Task created.");
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

internal class Programmer : IProgrammer
{
    public void WorkOnTask()
    {
        Console.WriteLine("Started working on the task.");
    }
}
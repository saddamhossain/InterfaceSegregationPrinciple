namespace InterfaceSegregationPrinciple;

/*
 Let's consider a scenario where we're designing a document processing system. We have different types of documents, and each document might require different
 actions to be performed on it. We'll use the ISP to ensure that our interfaces are specific needs of the implementing classes.
 */


// Interfaces
interface IReadable
{
    void Read();
}

interface IWritable
{
    void Write();
}

interface IPrintable
{
    void Print();
}

// Implementing classes

class TextDocument : IReadable, IWritable
{
    public void Read()
    {
        Console.WriteLine("Reading text document");
    }

    public void Write()
    {
        Console.WriteLine("Writing text document");
    }
}

class PDFDocument : IReadable, IPrintable
{
    public void Read()
    {
        Console.WriteLine("Reading PDF document");
    }

    public void Print()
    {
        Console.WriteLine("Printing PDF document");
    }
}

/*
 In this example:

We have three interfaces: IReadable, IWritable, and IPrintable. Each interface represents a specific action that documents can perform.
We have two classes: TextDocument and PDFDocument, representing different types of documents. Each class implements the appropriate interfaces based on its capabilities.

The TextDocument class only implements the IReadable and IWritable interfaces, which are relevant to its capabilities.
The PDFDocument class only implements the IReadable and IPrintable interfaces, which are relevant to its capabilities.

This approach ensures that implementing classes are not forced to implement methods they don't need.
By adhering to the ISP, we create more maintainable and focused interfaces that promote better separation of concerns.
 */
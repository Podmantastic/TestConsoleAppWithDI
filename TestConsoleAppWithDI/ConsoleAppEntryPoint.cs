namespace TestConsoleAppWithDI;

public partial class ConsoleAppEntryPoint : IConsoleAppEntryPoint
{
    public void Do()
    {
        List<string> order = [
            new("Laptop"),
            new("Mouse"),
            new("Laptop"),
            new("Keyboard"),
            new("Mac Mini")
            ];

        SortedSet<string> sortedOrder = [.. order];
        foreach (string item in sortedOrder)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Hello from ConsoleAppEntryPoint!");
    }
}
 

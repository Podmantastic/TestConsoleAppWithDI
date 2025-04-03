namespace TestConsoleAppWithDI;

public class ConsoleAppEntryPoint : IConsoleAppEntryPoint
{
    public void Do()
    {
        List<string> order = [
            new("Laptop"),
            new("Mouse"),
            new("Keyboard")];

        Console.WriteLine("Hello from ConsoleAppEntryPoint!");
    }
}

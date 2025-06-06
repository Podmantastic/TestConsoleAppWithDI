namespace TestConsoleAppWithDI;

public partial class ConsoleAppEntryPoint : IConsoleAppEntryPoint
{
    public void Do()
    {
        string message = "Hello from ConsoleAppEntryPoint!";
        string reverseMessage = new([.. message.Reverse()]);

        int limit = 10;
        var evenIntegers = GetSequenceOfEvenIntegersToLimit(limit);
        Console.WriteLine("Even integers up to " + limit + ": " + string.Join(", ", evenIntegers));
    
        Console.WriteLine($"{message} backwards is {reverseMessage}");
        Console.WriteLine($"Current date and time: {DateTime.Now}");
    }

    static IEnumerable<int> GetSequenceOfEvenIntegersToLimit(int limit)
    {
        if (limit < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(limit), "Limit must be a non-negative integer.");
        }

        for (int i = 0; i <= limit; i++)
        {
            if (i % 2 == 0)
            {
                yield return i;
            }
        }
    }
}


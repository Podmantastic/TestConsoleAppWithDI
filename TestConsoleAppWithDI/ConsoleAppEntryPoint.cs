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

    public int solution(int[] A)
    {
        // check the array values are in the range [−1,000,000..1,000,000]
        foreach (int num in A)
        {
            if (num < -1000000 || num > 1000000)
            {
                Console.WriteLine("Number out of range: " + num);
                return -1;
            }
            Console.WriteLine(num);
        }

        // read only positive numbers into a SortedSet
        HashSet<int> positiveNumbers = [];
        foreach (int num in A)
        {
            if (num > 0)
            {
                positiveNumbers.Add(num);
            }
        }

        // check if the array is empty
        if (positiveNumbers.Count == 0)
        {
            return 1;
        }

        // iterate from 1 to the array A length + 1
        for (int i = 1; i <= positiveNumbers.Count; i++)
        {
            // check if the number is in the set
            if (!positiveNumbers.Contains(i))
            {
                return i;
            }
        }
      
        return positiveNumbers.Count + 1;
    }
}

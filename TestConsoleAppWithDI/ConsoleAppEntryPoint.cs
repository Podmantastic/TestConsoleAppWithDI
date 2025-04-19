namespace TestConsoleAppWithDI;

public partial class ConsoleAppEntryPoint : IConsoleAppEntryPoint
{
    public void Do()
    {
        List<string> order = [
            new("Laptop"),
            new("Mouse"),
            new("Keyboard")];

        Console.WriteLine("Hello from ConsoleAppEntryPoint!");
    }

    // Method finds the position of N in the sorted array A.
    // If N is not found, it returns -1.
    // The method uses binary search to find the position of N in the array.
    // The array A must be sorted in ascending order.
    // The method has a time complexity of O(log N) and a space complexity of O(1).
    public int FindPositionInArray(int[] A, int X)
    {
        int N = A.Length;
        if (N == 0)
        {
            return (-1);
        }
        int l = 0;
        int r = N - 1;
        while (l < r)
        {
            int m = (l + r) / 2;
            if (A[m] > X)
            {
                r = m - 1;
            }
            else
            {
                l = m;
            }
        }
        if (A[l] == X)
        {
            return l;
        }
        return -1;
    }
}

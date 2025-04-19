namespace TestConsoleAppWithDI;

public partial class ConsoleAppEntryPoint
{
    public int FindLargestMissingPositiveInteger(int[] A)
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

    // This method calculates the binary gap of a number N.
    // A binary gap is defined as the maximum sequence of consecutive zeros
    // that is surrounded by ones in the binary representation of N.
    // For example, the binary representation of 9 is 1001, which has a binary gap of 2.
    // The binary representation of 529 is 1000010001, which has a binary gap of 4.
    // The binary representation of 20 is 10100, which has a binary gap of 1.
    // The binary representation of 15 is 1111, which has a binary gap of 0.
    public int FindBinaryGap(int N)
    {
        int maxGap = 0;
        int currentGap = 0;
        bool countingGap = false;

        while (N > 0)
        {
            if ((N & 1) == 1) // Check if the least significant bit is 1
            {
                if (countingGap)
                {
                    maxGap = Math.Max(maxGap, currentGap);
                }
                countingGap = true; // Start counting a new gap (or end the current one)
                currentGap = 0;     // Reset currentGap after encountering a '1'
            }
            else
            {
                if (countingGap)
                {
                    currentGap++; // Increment gap length if we are counting
                }
            }
            N >>= 1; // Right shift N by 1 (equivalent to dividing by 2)
        }
        return maxGap;
    }
}
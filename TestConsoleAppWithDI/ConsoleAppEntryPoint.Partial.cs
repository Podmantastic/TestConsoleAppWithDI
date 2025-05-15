namespace TestConsoleAppWithDI;

public partial class ConsoleAppEntryPoint
{
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
            return -1;
        }
        int l = 0;
        int r = N - 1;
        while (l <= r)
        {
            int m = (l + r) / 2;
            if (A[m] == X)
            {
                return m;
            }
            else if (A[m] > X)
            {
                r = m - 1;
            }
            else
            {
                l = m + 1;
            }
        }
        return -1;
    }

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

    /// <summary>
    /// Codesignal example excercise to calculate the number of zigzags in an array.
    /// </summary>
    /// <param name="numbers"></param>
    /// <returns></returns>
    private static int[] Solution(int[] numbers)
    {
        int[] result = new int[numbers.Length - 2];

        int resultPosition = 0;
        result[0] = 0;

        Console.WriteLine($"input()numbers) length: {numbers.Length}");
        foreach (var num in numbers)
        {
            Console.WriteLine($"input()numbers): {num}");
        }

        // slice input array into an array of triplets
        int[][] triplets = new int[numbers.Length - 2][];

        int tripletCount = 0;

        for (var i = 0; i <= numbers.Length; i++)
        {
            if (i + 2 >= numbers.Length) break;

            triplets[tripletCount++] = [numbers[i + 0], numbers[i + 1], numbers[i + 2]];
        }

        for (int i = 0; i < triplets.Length; i++)
        {
            Console.WriteLine($"Inner array {i}: [{string.Join(", ", triplets[i])}]");
        }

        // update result analysing each triplet
        for (int i = 0; i < triplets.Length; i++)
        {
            if (triplets[i][0] < triplets[i][1] && triplets[i][1] > triplets[i][2] ||
                triplets[i][0] > triplets[i][1] && triplets[i][1] < triplets[i][2])
            {
                result[resultPosition++] = 1;
            }
            else
            {
                result[resultPosition++] = 0;
            }
        }

        return result;
    }

    // Q1: find first largest rating/price ration from two arrays
    // Q2: ?
    // Q3: An inially empty number array has a set of queries applied [+2, +3, -3, +4], then an array is returned which shows the triplets that
    // apply a diff value.
    // Q4: rotate right a 2D array and apply gravity, taking into acount blockers.

     /// <summary>
    /// Rotates a 2D integer array to the right by 90 degrees.
    /// </summary>
    /// <param name="matrix">The 2D integer array to rotate.</param>
    /// <returns>A new 2D integer array representing the rotated matrix.
    /// Returns null if the input matrix is null or empty.</returns>
    public static int[,] RotateRight(int[,] matrix)
    {
        // Check for null or empty input
        if (matrix == null || matrix.GetLength(0) == 0 || matrix.GetLength(1) == 0)
        {
            return null; // Or throw an exception if you prefer:  throw new ArgumentException("Input matrix cannot be null or empty.");
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        // Create a new matrix with dimensions swapped (cols x rows)
        int[,] rotatedMatrix = new int[cols, rows];

        // Perform the rotation
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                // The key to rotation:
                // - The element at matrix[i, j] in the original matrix
                // - Moves to rotatedMatrix[j, rows - 1 - i] in the rotated matrix
                rotatedMatrix[j, rows - 1 - i] = matrix[i, j];
            }
        }

        return rotatedMatrix;
    }

    /// <summary>
    /// Prints a 2D integer array to the console for easy visualization.
    /// </summary>
    /// <param name="matrix">The 2D integer array to print.</param>
    public static void PrintMatrix(int[,] matrix)
    {
        if (matrix == null)
        {
            Console.WriteLine("Matrix is null.");
            return;
        }

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine(); // Move to the next row
        }
    }

    public static void TestMatrixRotation()
    {
        // Example usage
        int[,] originalMatrix = new int[,]
        {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };

        Console.WriteLine("Original Matrix:");
        PrintMatrix(originalMatrix);

        int[,] rotatedMatrix = RotateRight(originalMatrix);

        if (rotatedMatrix != null)
        {
            Console.WriteLine("\nRotated Matrix (Right 90 degrees):");
            PrintMatrix(rotatedMatrix);
        }
        else
        {
            Console.WriteLine("\nCannot rotate null or empty matrix.");
        }

        // Example with a rectangular matrix
        int[,] rectangularMatrix = new int[,]
        {
            {1, 2, 3, 4},
            {5, 6, 7, 8},
            {9, 10, 11, 12}
        };

        Console.WriteLine("\nOriginal Rectangular Matrix:");
        PrintMatrix(rectangularMatrix);

        int[,] rotatedRectangularMatrix = RotateRight(rectangularMatrix);

        if (rotatedRectangularMatrix != null)
        {
            Console.WriteLine("\nRotated Rectangular Matrix (Right 90 degrees):");
            PrintMatrix(rotatedRectangularMatrix);
        }
        else
        {
             Console.WriteLine("\nCannot rotate null or empty matrix.");
        }

        // Example with an empty matrix
        int[,] emptyMatrix = new int[0, 0];
        Console.WriteLine("\nEmpty Matrix:");
        PrintMatrix(emptyMatrix);
        int[,] rotatedEmptyMatrix = RotateRight(emptyMatrix);
        if(rotatedEmptyMatrix != null)
        {
            Console.WriteLine("Rotated Empty Matrix:");
            PrintMatrix(rotatedEmptyMatrix);
        }
        else
        {
            Console.WriteLine("Cannot rotate null or empty matrix.");
        }

        // Example with a null matrix
        int[,] nullMatrix = null;
        Console.WriteLine("\nNull Matrix:");
        PrintMatrix(nullMatrix);
        int[,] rotatedNullMatrix = RotateRight(nullMatrix);
        if (rotatedNullMatrix != null)
        {
            Console.WriteLine("Rotated Null Matrix:");
            PrintMatrix(rotatedNullMatrix);
        }
        else
        {
            Console.WriteLine("Cannot rotate null or empty matrix.");
        }
    }
}
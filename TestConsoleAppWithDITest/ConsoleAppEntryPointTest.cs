using Moq;
using NUnit.Framework;
using TestConsoleAppWithDI;

namespace TestConsoleAppWithDITest;

[TestFixture]
public class ConsoleAppEntryPointTest
{
    private ConsoleAppEntryPoint _entryPoint = null!;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _entryPoint = new ConsoleAppEntryPoint();
    }

    // FindLargestMissingPositiveInteger Tests
    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturn1_WhenArrayIsEmpty()
    {
        int[] input = [];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturn1_WhenNoPositiveNumbers()
    {
        int[] input = [-1, -2, -3];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturnSmallestMissingPositiveNumber()
    {
        int[] input = [1, 3, 6, 4, 1, 2];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(5));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturnNextPositiveNumber_WhenAllNumbersAreSequential()
    {
        int[] input = [1, 2, 3];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldReturnMinus1_WhenNumberOutOfRange()
    {
        int[] input = [1, 2, 1000001];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void FindLargestMissingPositiveInteger_ShouldIgnoreNegativeNumbersAndReturnSmallestMissingPositive()
    {
        int[] input = [-1, -3, 1, 2, 4];
        int result = _entryPoint.FindLargestMissingPositiveInteger(input);
        Assert.That(result, Is.EqualTo(3));
    }

    // FindBinaryGap Tests
    [Test]
    public void FindBinaryGap_ShouldReturn0_WhenNoBinaryGapExists()
    {
        int input = 15; // Binary: 1111
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void FindBinaryGap_ShouldReturn2_WhenBinaryGapIs2()
    {
        int input = 9; // Binary: 1001
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void FindBinaryGap_ShouldReturn4_WhenBinaryGapIs4()
    {
        int input = 529; // Binary: 1000010001
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(4));
    }

    [Test]
    public void FindBinaryGap_ShouldReturn1_WhenBinaryGapIs1()
    {
        int input = 20; // Binary: 10100
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(1));
    }

    [Test]
    public void FindBinaryGap_ShouldReturn0_WhenInputIs0()
    {
        int input = 0; // Binary: 0
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void FindBinaryGap_ShouldHandleLargeNumbersCorrectly()
    {
        int input = 1041; // Binary: 10000010001
        int result = _entryPoint.FindBinaryGap(input);
        Assert.That(result, Is.EqualTo(5));
    }

    // FindpositionInArray Tests
    [Test]
    public void FindPositionInArray_ShouldReturnMinus1_WhenArrayIsEmpty()
    {
        int[] input = new int[] { };
        int result = _entryPoint.FindPositionInArray(input, 5);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void FindPositionInArray_ShouldReturnCorrectIndex_WhenElementExists()
    {
        int[] input = new int[] { 1, 3, 5, 7, 9 };
        int result = _entryPoint.FindPositionInArray(input, 5);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void FindPositionInArray_ShouldReturnMinus1_WhenElementDoesNotExist()
    {
        int[] input = new int[] { 1, 3, 5, 7, 9 };
        int result = _entryPoint.FindPositionInArray(input, 4);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void FindPositionInArray_ShouldReturnCorrectIndex_WhenElementIsAtStart()
    {
        int[] input = new int[] { 1, 3, 5, 7, 9 };
        int result = _entryPoint.FindPositionInArray(input, 1);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void FindPositionInArray_ShouldReturnCorrectIndex_WhenElementIsAtEnd()
    {
        int[] input = new int[] { 1, 3, 5, 7, 9 };
        int result = _entryPoint.FindPositionInArray(input, 9);
        Assert.That(result, Is.EqualTo(4));
    }
}

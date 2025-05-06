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

    // FindpositionInArray Tests
    [Test]
    public void FindPositionInArray_ShouldReturnMinus1_WhenArrayIsEmpty()
    {
        int[] input = [];
        int result = _entryPoint.FindPositionInArray(input, 5);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void FindPositionInArray_ShouldReturnCorrectIndex_WhenElementExists()
    {
        int[] input = [1, 3, 5, 7, 9];
        int result = _entryPoint.FindPositionInArray(input, 5);
        Assert.That(result, Is.EqualTo(2));
    }

    [Test]
    public void FindPositionInArray_ShouldReturnMinus1_WhenElementDoesNotExist()
    {
        int[] input = [1, 3, 5, 7, 9];
        int result = _entryPoint.FindPositionInArray(input, 4);
        Assert.That(result, Is.EqualTo(-1));
    }

    [Test]
    public void FindPositionInArray_ShouldReturnCorrectIndex_WhenElementIsAtStart()
    {
        int[] input = [1, 3, 5, 7, 9];
        int result = _entryPoint.FindPositionInArray(input, 1);
        Assert.That(result, Is.EqualTo(0));
    }

    [Test]
    public void FindPositionInArray_ShouldReturnCorrectIndex_WhenElementIsAtEnd()
    {
        int[] input = [1, 3, 5, 7, 9];
        int result = _entryPoint.FindPositionInArray(input, 9);
        Assert.That(result, Is.EqualTo(4));
    }
}

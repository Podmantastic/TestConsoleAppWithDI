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

    [Test]
    public void Do_PrintsExpectedOutput()
    {
        // Arrange
        using var sw = new StringWriter();
        Console.SetOut(sw);

        // Act
        _entryPoint.Do();

        // Assert
        var output = sw.ToString();
        Assert.That(output, Does.Contain("Hello from ConsoleAppEntryPoint! backwards is !tnioPyrtnEppAelosnoC morf olleH"));
        Assert.That(output, Does.Contain("Even integers up to 10: 0, 2, 4, 6, 8, 10"));
        Assert.That(output, Does.Contain("Current date and time:"));
    }
}

using System.Linq;
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
        Assert.That(output, Does.Contain("Hello from ConsoleAppEntryPoint!"));
    }
}

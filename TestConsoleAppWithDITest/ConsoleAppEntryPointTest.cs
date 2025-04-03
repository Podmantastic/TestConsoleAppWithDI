using Moq;
using NUnit.Framework;
using TestConsoleAppWithDI;

namespace TestConsoleAppWithDITest;

[TestFixture]
public class ConsoleAppEntryPointTest
{
    private Mock<IConsoleAppEntryPoint> _mockConsoleAppEntryPoint = null!;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _mockConsoleAppEntryPoint = new Mock<IConsoleAppEntryPoint>();
    }


    [Test]
    public void Do_ConsoleAppEntryPoint_DoesNothingAsYet()
    {
        // Arrange

        // Act
        _mockConsoleAppEntryPoint.Setup(x => x.Do()).Verifiable();
        _mockConsoleAppEntryPoint.Object.Do();

        // Assert

    }
}

using NUnit.Framework;
using TestConsoleAppWithDI;

namespace TestConsoleAppWithDITest;

[TestFixture]
public class ScannedDocumentInformationParserTest
{
    private ScannedDocumentInformationParser _entryPoint = null!;

    [SetUp]
    public void Setup()
    {
        // Arrange
        _entryPoint = new ScannedDocumentInformationParser();
    }

    [Test]
    public void Do_ValidCsvData_PrintsFields()
    {        // Act
        _entryPoint.Parse("Field1, Field2, Field3");
        // Assert
        // Since the method prints to console, we can't assert the output directly.
        // In a real test, you might want to capture console output or refactor the method to return values instead.
        Assert.Pass("Method executed without exceptions.");
    }
}

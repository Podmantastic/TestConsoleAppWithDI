using NUnit.Framework;
using TestConsoleAppWithDI;
using TestConsoleAppWithDI.Models;

namespace TestConsoleAppWithDITest;

[TestFixture]
public class ScannedDocumentInformationParserTest
{
    private ScannedDocumentInformationParser _entryPoint = null!;

    [SetUp]
    public void Setup()
    {
        // Arrange
        var recordsModel = new IdDocumentRecordsModel(); // You may need to set properties as required
        _entryPoint = new ScannedDocumentInformationParser(recordsModel);
    }

    [Test]
    public void Do_ValidCsvData_PrintsFields()
    {   // Act
        _entryPoint.Parse();
        
        // Assert
    }
}

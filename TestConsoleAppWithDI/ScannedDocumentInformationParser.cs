namespace TestConsoleAppWithDI;

public partial class ScannedDocumentInformationParser : IScannedDocumentInformationParser
{
    public void Parse(string idDocumentCsv)
    {
        // Simulate parsing the CSV data
        if (string.IsNullOrWhiteSpace(idDocumentCsv))
        {
            throw new ArgumentException("CSV data cannot be null or empty", nameof(idDocumentCsv));
        }

        // Here you would typically parse the CSV and extract information
        // For demonstration, we will just print the CSV data
        Console.WriteLine($"ScannedDocumentInformationParser: {idDocumentCsv}");

        // parse the variable length CSV data
        var fields = idDocumentCsv.Split(',');
        foreach (var field in fields)
        {
            Console.WriteLine($"Field: {field.Trim()}");
        }
    }
}


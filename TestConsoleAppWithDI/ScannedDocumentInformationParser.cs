using TestConsoleAppWithDI.DTO;
using TestConsoleAppWithDI.Models;

namespace TestConsoleAppWithDI;

public class ScannedDocumentInformationParser : IScannedDocumentInformationParser
{
    private readonly IdDocumentRecordsModel _recordsModel;

    public ScannedDocumentInformationParser(IdDocumentRecordsModel recordsModel)
    {
        _recordsModel = recordsModel;
    }

    public string Parse()
    {

        // TODO: this methos should just read the imput and call the parsing logic
        // we to inject the model and a new class to handle the parsing logic


        // TODO: just returning what was read, but this should be replaced with actual parsing logic
        if (_recordsModel.Records.Count == 0)
        {
            return "No records found.";
        }
        return string.Join(Environment.NewLine, _recordsModel.Records.Select(r =>
            $"{r.Id}, {r.Type}, {r.Country}, {r.LastName}, {r.FirstName}, {r.Number}, {r.Nationality}, {r.IssueDate}, {r.ExpiryDate}"));
    }
}


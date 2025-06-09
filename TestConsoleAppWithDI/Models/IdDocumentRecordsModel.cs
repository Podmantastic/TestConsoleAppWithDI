using System;
using TestConsoleAppWithDI.DTO;

namespace TestConsoleAppWithDI.Models;

public class IdDocumentRecordsModel
{
    private readonly List<IdDocumentRecord> _records = new();

    public IReadOnlyList<IdDocumentRecord> Records => _records.AsReadOnly();

    public void Add(IdDocumentRecord record)
    {
        _records.Add(record);
    }
}

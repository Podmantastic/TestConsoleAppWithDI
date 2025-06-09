using System;
using TestConsoleAppWithDI.DTO;
using TestConsoleAppWithDI.Models;

namespace TestConsoleAppWithDI;

public class IdDocumentLoader : IIdDocumentLoader
{
    private readonly IdDocumentRecordsModel _recordsModel;

    public IdDocumentLoader(IdDocumentRecordsModel recordsModel)
    {
        _recordsModel = recordsModel;
    }

    public void ReadConsoleInput()
    {
             // request number of records
        Console.Write("Enter the number of ID document records to read: ");

        // validate input
        if (!int.TryParse(Console.ReadLine(), out int numberOfRecords) || numberOfRecords <= 0)
        {
            throw new ArgumentException("Invalid number of records specified.", nameof(numberOfRecords));
        }

        var records = new IdDocumentRecord[numberOfRecords];

        for (int i = 0; i < numberOfRecords; i++)
        {
            Console.WriteLine($"Enter details for record {i + 1} (format: Id,Type,Country,LastName,FirstName,Number,Nationality,IssueDate,ExpiryDate):");
            var input = Console.ReadLine();
            if (input == null)
            {
                throw new ArgumentException("Input cannot be null.", nameof(input));
            }

            var fields = input.Split(',');
            if (fields.Length != 9)
            {
                throw new ArgumentException("Invalid input format. Expected 9 fields separated by commas.", nameof(input));
            }

            records[i] = new IdDocumentRecord(
                Id: int.Parse(fields[0].Trim()),
                Type: fields[1].Trim(),
                Country: fields[2].Trim(),
                LastName: fields[3].Trim(),
                FirstName: fields[4].Trim(),
                Number: fields[5].Trim(),
                Nationality: fields[6].Trim(),
                IssueDate: fields[7].Trim(),
                ExpiryDate: fields[8].Trim()
            );
        }
        // Add records to the model
        foreach (var record in records)
        {
            _recordsModel.Add(record);
        }   
    }
}
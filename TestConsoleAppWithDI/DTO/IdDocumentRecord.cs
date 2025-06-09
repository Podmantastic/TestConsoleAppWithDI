using System;

namespace TestConsoleAppWithDI.DTO;

public record IdDocumentRecord
(
    int Id,
    string Type,
    string Country,
    string LastName,
    string FirstName,
    string Number,
    string Nationality,
    string IssueDate,
    string ExpiryDate
);

# TestConsoleAppWithDI

This solution serves as a base for exploring and testing new features of C# .NET 9, with a focus on Dependency Injection (DI) and unit testing using NUnit.

## Project Structure

### TestConsoleAppWithDI
This is the main console application project. It includes:
- **`ConsoleAppEntryPoint.cs`**: The entry point for the application logic.
- **`IConsoleAppEntryPoint.cs`**: Interface for the entry point, enabling dependency injection.
- **`Program.cs`**: The main entry point of the application.
- **`Boot/`**: Contains the `Bootstrapper` and `Module` classes for setting up DI.

### TestConsoleAppWithDITest
This is the test project for the console application. It includes:
- **`ConsoleAppEntryPointTest.cs`**: NUnit test cases for the console application entry point.

## Features
- **C# .NET 9**: Leverages new language features introduced in .NET 9.
- **Dependency Injection**: Implements DI using a modular approach.
- **Unit Testing**: Uses NUnit for writing and running tests.

## Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/Podmantastic/TestConsoleAppWithDI
2. Open the solution in Visual Studio or your preferred IDE.
3. Build the solution:
   ```bash
   dotnet build
4. Run the application:
   ```bash
   dotnet run --project TestConsoleAppWithDI
5. Run the tests:
   ```bash
   dotnet test
## Requirements
.NET SDK 9.0 or later
NUnit for testing

## Contributing
Feel free to fork this repository and submit pull requests to add new features or improve the existing code.

## License
This project is licensed under the MIT License. ```
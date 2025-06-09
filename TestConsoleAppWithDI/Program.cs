using TestConsoleAppWithDI.Boot;

// get the input line by line an build the model
Bootstrapper.ResolveGenerator().Parse();

// parse the model and generate the output
Bootstrapper.ResolveGenerator().Parse();

Console.WriteLine("Press a key to quit.");
Console.Read();

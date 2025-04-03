using TestConsoleAppWithDI.Boot;

Bootstrapper.ResolveGenerator().Do();

Console.WriteLine("Press a key to quit.");
Console.Read();

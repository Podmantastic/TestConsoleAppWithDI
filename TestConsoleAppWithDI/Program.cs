using TestConsoleAppWithDI.Boot;

Bootstrapper.ResolveGenerator().Parse(args.Length > 0 ? args[0] : "");

Console.WriteLine("Press a key to quit.");
Console.Read();

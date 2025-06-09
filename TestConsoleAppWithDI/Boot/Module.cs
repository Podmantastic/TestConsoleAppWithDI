
namespace TestConsoleAppWithDI.Boot;

public class Module : Ninject.Modules.NinjectModule
{
    public override void Load()
    {
        // Entry point
        Bind<IScannedDocumentInformationParser>().To<ScannedDocumentInformationParser>().InSingletonScope();
    }
}


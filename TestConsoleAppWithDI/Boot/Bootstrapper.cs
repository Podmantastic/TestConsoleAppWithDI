using Ninject;

namespace TestConsoleAppWithDI.Boot;

internal class Bootstrapper
{
  public static IScannedDocumentInformationParser ResolveGenerator()
  {
    var kernel = new StandardKernel(new NinjectSettings(), new Module());

    return kernel.Get<IScannedDocumentInformationParser>();
  }
}

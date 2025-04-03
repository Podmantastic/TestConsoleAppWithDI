using Ninject;

namespace TestConsoleAppWithDI.Boot;

internal class Bootstrapper
{
  public static IConsoleAppEntryPoint ResolveGenerator()
    {
        var kernel = new StandardKernel(new NinjectSettings(), new Module());

        return kernel.Get<IConsoleAppEntryPoint>();
    }
}

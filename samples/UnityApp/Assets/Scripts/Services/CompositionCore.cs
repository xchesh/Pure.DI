using Pure.DI;

public partial class CompositionCore
{
    void Setup() => DI.Setup(nameof(CompositionCore), CompositionKind.Internal)
                        .DefaultLifetime(Lifetime.Singleton)
                        .Bind<IServiceA>().To<ServiceA>()
                        .Bind<IServiceB>().To<ServiceB>()
                        .Bind<IServiceC>().To<ServiceC>();
}
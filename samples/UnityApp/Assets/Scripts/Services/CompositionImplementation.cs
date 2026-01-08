using System;
using Pure.DI;
using UnityEngine.Assertions;

public partial class CompositionImplementation
{
    void Setup() => DI.Setup()
                        .DependsOn(nameof(CompositionCore))
                        .DefaultLifetime(Lifetime.Singleton)
                        .Bind<IProviderA>(Tag.Unique).Bind<IProviderA1>().To<ProviderA1>()
                        .Bind<IProviderA>(Tag.Unique).Bind<IProviderA2>().To<ProviderA2>()
                        .Bind<IProviderB>(Tag.Unique).Bind<IProviderB1>().To<ProviderB1>()
                        .Bind<IProviderB>(Tag.Unique).Bind<IProviderB2>().To<ProviderB2>()
                        .Bind<Manager>().To<Manager>()
                        .Root<Root>(nameof(Root));
}


public partial class Root
{
    public Root(Manager manager)
    {
        Assert.IsNotNull(manager);
    }

    public void Run()
    {
        UnityEngine.Debug.Log("Composition Root is running!");
    }
}
using System.Collections.Generic;
using System.Linq;
using UnityEngine.Assertions;

public interface IServiceA
{
}

public class ServiceA : IServiceA
{
    public ServiceA(IEnumerable<IProviderA> providers)
    {
        Assert.IsNotNull(providers);
        Assert.IsTrue(providers.Count() > 0);
    }
}
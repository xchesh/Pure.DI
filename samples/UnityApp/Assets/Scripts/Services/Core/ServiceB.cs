using System.Collections.Generic;
using System.Linq;
using UnityEngine.Assertions;

public interface IServiceB
{
}

public class ServiceB : IServiceB
{
    public ServiceB(IEnumerable<IProviderB> providers)
    {
        Assert.IsNotNull(providers);
        Assert.IsTrue(providers.Count() > 0);
    }
}
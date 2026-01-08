using UnityEngine.Assertions;

public class Manager
{
    public Manager(IServiceC serviceC, IProviderA1 providerA1)
    {
        Assert.IsNotNull(serviceC);
        Assert.IsNotNull(providerA1);
    }
}
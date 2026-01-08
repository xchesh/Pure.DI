using UnityEngine.Assertions;

public interface IServiceC
{
}

public class ServiceC : IServiceC
{
    public ServiceC(ServiceB serviceB)
    {
        Assert.IsNotNull(serviceB);
    }
}
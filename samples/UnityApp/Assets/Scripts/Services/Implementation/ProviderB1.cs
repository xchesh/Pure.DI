using UnityEngine.Assertions;

public interface IProviderB1
{
}

public class ProviderB1 : IProviderB, IProviderB1
{
    public ProviderB1(IServiceC serviceC)
    {
        Assert.IsNotNull(serviceC);
    }

    public int GetNumber()
    {
        return 1;
    }
}
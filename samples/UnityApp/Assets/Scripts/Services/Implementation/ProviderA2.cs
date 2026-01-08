public interface IProviderA2
{
}

public class ProviderA2 : IProviderA, IProviderA2
{
    public string GetData()
    {
        return "ProviderA2 Data";
    }
}
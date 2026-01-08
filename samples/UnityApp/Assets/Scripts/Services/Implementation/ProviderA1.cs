public interface IProviderA1
{
}

public class ProviderA1 : IProviderA, IProviderA1
{
    public string GetData()
    {
        return "ProviderA1 Data";
    }
}

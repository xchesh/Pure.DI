public interface IProviderB2
{
}

public class ProviderB2 : IProviderB, IProviderB2
{
    public int GetNumber()
    {
        return 2;
    }
}
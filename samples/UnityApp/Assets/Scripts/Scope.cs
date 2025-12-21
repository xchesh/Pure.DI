using Pure.DI;
using UnityEngine;
using static Pure.DI.Lifetime;

public partial class Scope: MonoBehaviour
{
    [SerializeField]
    public ClockConfig clockConfig;

    void Setup() => DI.Setup()
        .Bind().To(_ => clockConfig)
        .Bind().As(Singleton).To<ClockService>()
        .Builders<MonoBehaviour>();

    void OnDestroy()
    {
        Dispose();
    }
}

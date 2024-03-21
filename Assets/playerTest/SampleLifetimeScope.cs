using UnityEngine;
using VContainer;
using VContainer.Unity;

public class SampleLifetimeScope : LifetimeScope
{
    [SerializeField] int playerHp;//追記1
    [SerializeField] string name;
    [SerializeField] int power;
    
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<Shield>(Lifetime.Singleton); //追記2
        builder.Register<Weapon>(Lifetime.Singleton).WithParameter("name", name).WithParameter<int>(power);　//追記3
        builder.RegisterEntryPoint<Player>().WithParameter<int>(playerHp); //追記4
    }
}

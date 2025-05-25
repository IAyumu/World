using UnityEngine;
using VContainer;
using VContainer.Unity;
using World;

public class GlobalLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<CharacterManager>(Lifetime.Singleton);
    }

    protected override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(gameObject);
    }
}
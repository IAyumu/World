using UnityEngine;
using VContainer.Unity;
using VContainer;

namespace World
{
    public class MainSceneLifeTimeScope : LifetimeScope
    {
        [SerializeField] private MainScene mainScene;
        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterComponent(mainScene);

        }
    }
}

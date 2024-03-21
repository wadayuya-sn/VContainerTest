using VContainer;
using VContainer.Unity;

/// <summary>
/// VContainer用のContainerクラス
/// </summary>
public class TestLifetimeScope : LifetimeScope
{
    protected override void Configure(IContainerBuilder builder)
    {
        builder.Register<IInputModelInterface,EditorInputModel>(Lifetime.Scoped);
     
        builder.RegisterComponentInHierarchy<TestView>();
        //VContainerTestPresenterはどこからもResolveされないので明示的にエントリーポイントとする
        builder.RegisterEntryPoint<VContainerTestPresenter>(Lifetime.Scoped);
    }
}
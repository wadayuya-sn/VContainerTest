using UnityEngine;
using VContainer;

public sealed class TestMonoBehaviour : MonoBehaviour
{
    private void Start()
    {
        // 1. IContainerBuilderを生成
        ContainerBuilder calculatorBuilder = new ContainerBuilder();
        ContainerBuilder debugBuilder = new ContainerBuilder();

        // 2. IContainerBuilderに使いたいクラスを登録
        calculatorBuilder.Register<CalculatorManager>(Lifetime.Singleton);
        calculatorBuilder.Register<CalculatorHoge>(Lifetime.Singleton);

        debugBuilder.Register<DebugLogManager>(Lifetime.Singleton);
        debugBuilder.Register<DebugHoge>(Lifetime.Singleton);
        
        // 3. IContainerBuilderからIObjectResolverを生成
        IObjectResolver calulatorObjectResolver = calculatorBuilder.Build();
        IObjectResolver debugObjectResolver = debugBuilder.Build();
        
        // 4. IObjectResolverで使いたいクラスを生成
        CalculatorHoge calculatorHoge = calulatorObjectResolver.Resolve<CalculatorHoge>();
        DebugHoge debugHoge = debugObjectResolver.Resolve<DebugHoge>();
        
        string x = calculatorHoge.CalculatorTest(3, 5); // [Logger] 3 + 5 = 8 と出力される
        debugHoge.LoggerTest(x);
        string y = calculatorHoge.MinusCalculatorTest(3, 5); // [Logger] 3 - 5 = -2 と出力される
        debugHoge.LoggerTest(y);
    }
}
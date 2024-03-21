using VContainer;


//Calculatorに依存するクラス
public sealed class CalculatorHoge
{
   
    private readonly CalculatorManager _calculatorManagerManager;
    
    [Inject]
    public CalculatorHoge(CalculatorManager calculatorManagerManager)
    {
        _calculatorManagerManager = calculatorManagerManager;
    }

    public string CalculatorTest(int a, int b)
    {
        int result = _calculatorManagerManager.Add(a, b);
         return $"{a} + {b} = {result}";
    }
    
    public int CalculatorAnswerTest(int a, int b)
    {
        int result = _calculatorManagerManager.Add(a, b);
        return result;
    }
    
    public string MinusCalculatorTest(int a, int b)
    {
        int result = _calculatorManagerManager.minus(a, b);
        return $"{a} - {b} = {result}";
    }
}
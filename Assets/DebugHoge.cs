using VContainer;

public sealed class DebugHoge
{
    private readonly DebugLogManager _logger;
   
    [Inject]
    public DebugHoge(DebugLogManager logger)
    {
        _logger = logger;
    }
    
    public void LoggerTest(string message)
    {
        _logger.Log(message);
    }
    
}

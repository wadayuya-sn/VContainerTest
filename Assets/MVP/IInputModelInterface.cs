public interface IInputModelInterface
{
    /// <summary>
    /// 値の監視に利用
    /// </summary>
    string InputTypeObservable { get; }
    
    /// <summary>
    /// 値の発行に利用
    /// </summary>
    void PublishValue();
    
}

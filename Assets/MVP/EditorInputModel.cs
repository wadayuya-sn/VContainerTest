using UnityEngine;

public class EditorInputModel:IInputModelInterface
{
    /// <summary>
    /// 購読機能のみ外部に公開
    /// </summary>
    public string InputTypeObservable => _inputType;
    private string _inputType = default;
   
    /// <summary>
    /// 値の発行(データの書き換え)
    /// </summary>
    public void PublishValue()
    {
        _inputType = Input.GetMouseButton(0) ? "Click" : "No Input";
    }
}

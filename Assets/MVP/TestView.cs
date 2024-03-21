using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// View
/// </summary>
public class TestView : MonoBehaviour
{
    [SerializeField] private Text _text;

    /// <summary>
    /// テキストをセットする
    /// </summary>
    /// <param name="t">受け取った文字列</param>
    public void SetText(string t)
    {
        _text.text = t;
    }
}
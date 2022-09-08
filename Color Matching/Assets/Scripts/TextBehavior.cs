using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class TextBehavior : MonoBehaviour
{
    public Text label;
    public UnityEvent startEvent;
    void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateText(FloatSO dataObj)
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
    
    public void UpdateText(IntSO dataObj)
    {
        label.text = dataObj.value.ToString(CultureInfo.InvariantCulture);
    }
}

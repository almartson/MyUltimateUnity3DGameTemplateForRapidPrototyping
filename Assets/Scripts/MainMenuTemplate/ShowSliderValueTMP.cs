using System.Reflection.Emit;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(TextMeshProUGUI))]
public class ShowSliderValueTMP : MonoBehaviour
{
    public void UpdateLabel(float value)
    {
        TextMeshProUGUI lbl = GetComponent<TextMeshProUGUI>();
        if (lbl != null)
            lbl.text = Mathf.RoundToInt(value * 100) + "%";
    }

}

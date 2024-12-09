using System.Globalization;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace RKUnityToolkit.Samples.GenericListDisplaySamples
{
    public class FloatListItemController : UIElements.GenericListDisplay.ListItemController<float>
    {
        [SerializeField] private Image fill;
        [SerializeField] private TextMeshProUGUI text;
        
        protected override void OnDataSet(float data)
        {
            text.text = data.ToString(CultureInfo.CurrentCulture);
            fill.fillAmount = data;
        }
    }
}

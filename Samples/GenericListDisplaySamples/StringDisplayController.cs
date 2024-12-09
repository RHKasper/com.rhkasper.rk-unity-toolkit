using RKUnityToolkit.UIElements;
using TMPro;
using UnityEngine;

namespace RKUnityToolkit.Samples.GenericListDisplaySamples
{
    public class StringDisplayController : GenericListDisplay.ListItemController<string>
    {
        [SerializeField] private TextMeshProUGUI text;

        protected override void OnDataSet(string data)
        {
            text.text = data;
        }
    }
}

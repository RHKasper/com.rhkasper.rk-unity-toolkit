using Easing;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Samples.Easing
{
    public class EasingReadoutController : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI title;
        [SerializeField] private Image inputFill;
        [SerializeField] private Image outputFill;
        
        private EasingType _easingType;
        public void Init(EasingType easingType)
        {
            gameObject.name = $"Easing Readout - {easingType}"; 
            title.text = easingType.ToString();
            _easingType = easingType;
        }

        private void Update()
        {
            float input = Mathf.PingPong(Time.time, 1);

            inputFill.fillAmount = input;
            outputFill.fillAmount = EasingUtil.Ease(0,1, input, _easingType);
            
        }
    }
}

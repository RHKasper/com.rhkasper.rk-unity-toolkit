using System;
using Easing;
using UnityEngine;

namespace RKUnityToolkit.Samples.Easing
{
    public class EasingSampleController : MonoBehaviour
    {
        public GameObject instructions; 
        public EasingReadoutController easingReadoutPrefab;
        
        // Start is called before the first frame update
        void Start()
        {
            instructions.SetActive(false);
            foreach (EasingType easingType in Enum.GetValues(typeof(EasingType)))
            {
                EasingReadoutController easingReadout = Instantiate(easingReadoutPrefab, transform);
                easingReadout.Init(easingType);
            }
        }
    }
}

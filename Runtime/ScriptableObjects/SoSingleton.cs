using System;
using UnityEngine;

namespace RKUnityToolkit.ScriptableObjects
{
    public class SoSingleton<T> : ScriptableObject where T : ScriptableObject
    {
        public static T Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = Load();
                }
                return _instance;
            }
        }
        private static T _instance;
        
        protected static string GetResourcesPath()
        {
            foreach (object customAttribute in typeof (T).GetCustomAttributes(true))
            {
                if (customAttribute is SoResourcesPathAttribute attribute)
                {
                    return attribute.ResourcesPath;
                }
            }

            throw new Exception($"{nameof(SoResourcesPathAttribute)} attribute required on {typeof(T)}");
        }

        private static T Load()
        {
            return Resources.Load<T>(GetResourcesPath());
        }
        
    }
    
    public class SoResourcesPathAttribute : Attribute
    {
        public string ResourcesPath;
    }

}

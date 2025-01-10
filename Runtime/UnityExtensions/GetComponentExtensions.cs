using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace RKUnityToolkit.UnityExtensions
{
    public static class GetComponentExtensions
    {
        /// <summary>
        /// Gets all components of type <see cref="T"/> on this object's children.
        /// Does not recurse through children's children, etc.
        /// Includes components on inactive GameObjects
        /// </summary>
        public static T[] GetComponentsInDirectChildren<T>(this GameObject gameObject)
        {
            LinkedList<T> foundComponents = new LinkedList<T>();

            for (int i = 0; i < gameObject.transform.childCount; i++)
            {
                Transform child = gameObject.transform.GetChild(i);
                T component = child.GetComponent<T>();
                
                if (component != null)
                {
                    foundComponents.AddLast(component);
                }
            }

            return foundComponents.ToArray();
        }
    }
}

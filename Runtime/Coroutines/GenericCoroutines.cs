using System;
using System.Collections;
using UnityEngine;

namespace RKUnityToolkit.Coroutines
{
    public static class GenericCoroutines
    {
        public static IEnumerator DoNextFrame(Action action)
        {
            yield return null;
            action();
        }
        
        public static IEnumerator DoAfterFrames(Action action, int numFrames)
        {
            for (int i = 0; i < numFrames; i++)
            {
                yield return null;
            }
            action();
        }
    }
}
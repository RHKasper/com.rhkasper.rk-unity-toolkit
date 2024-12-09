using System;
using System.Collections.Generic;
using RKUnityToolkit.UIElements;
using UnityEngine;
using Random = System.Random;

namespace RKUnityToolkit.Samples.GenericListDisplaySamples
{
    public class GenericListDisplaySample : MonoBehaviour
    {
        [SerializeField] private GenericListDisplay listDisplay;
        [SerializeField] private FloatListItemController floatItemPrefab;

        private Random rng = new (100);

        private void Start()
        {
            RandomizeList();
        }

        public void RandomizeList()
        {
            listDisplay.DisplayList(GenerateRandomListOfFloats(), floatItemPrefab);
        }

        private List<float> GenerateRandomListOfFloats()
        {
            List<float> floats = new List<float>();
            for (int i = 0; i < 10; i++)
            {
                floats.Add((float)rng.NextDouble());
            }

            return floats;
        }
    }
}

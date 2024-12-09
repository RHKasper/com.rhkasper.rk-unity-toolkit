using System;
using System.Collections.Generic;
using NUnit.Framework;
using RKUnityToolkit.UIElements;
using UnityEngine;
using Random = System.Random;

namespace RKUnityToolkit.Samples.GenericListDisplaySamples
{
    public class GenericListDisplaySample : MonoBehaviour
    {
        [SerializeField] private GenericListDisplay listDisplay;
        [SerializeField] private FloatDisplayController floatDisplayPrefab;
        [SerializeField] private StringDisplayController stringDisplayPrefab;

        private Random rng = new (100);

        private void Start()
        {
            DisplayNewFloatList();
        }

        public void DisplayNewFloatList()
        {
            listDisplay.DisplayList(GenerateRandomListOfFloats(), floatDisplayPrefab);
        }

        public void DisplayNewStringList()
        {
            listDisplay.DisplayList(GenerateRandomListOfStrings(), stringDisplayPrefab);
        }

        private List<float> GenerateRandomListOfFloats()
        {
            List<float> floats = new List<float>{1};
            for (int i = 0; i < 10; i++)
            {
                floats.Add((float)rng.NextDouble());
            }

            return floats;
        }

        private List<string> GenerateRandomListOfStrings()
        {
            List<string> strings = new(){"hello world"};

            for (int i = 0; i < 10; i++)
            {
                int length = rng.Next(2, 10);
                string val = "";
                for (int j = 0; j < length; j++)
                {
                    char c = (char)('a' + rng.Next(0, 26));
                    val += c;
                }
                strings.Add(val);
            }

            return strings;
        }
    }
}

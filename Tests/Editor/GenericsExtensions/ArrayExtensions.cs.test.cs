using System.Collections.Generic;
using System.Linq;
using GenericsExtensions;
using NUnit.Framework;

namespace Tests.Editor.GenericsExtensions
{
	public static class ArrayExtensionsTests
	{
		[Test]
		public static void PopulateTest()
		{
			int[] arr = new int[15];
			Assert.False(arr.Any(v => v == 5));
			
			arr.Populate(5);
			Assert.True(arr.All(v => v == 5));
		}
		
		[Test]
		public static void GetRandomTest()
		{
			char[] arr = { 'a', '3', 'x' };

			int numTrials = 10000;
			float maxDelta = .1f;
			Dictionary<char, int> occurenceCount = new Dictionary<char, int>();

			foreach (char c in arr)
				occurenceCount[c] = 0;

			for (int i = 0; i < numTrials; i++)
				occurenceCount[arr.GetRandom()]++;

			float expectedFrequency = 1f / arr.Length;

			foreach (char c in arr)
				Assert.AreEqual(expectedFrequency, occurenceCount[c] / (float)numTrials, maxDelta);
		}
	}
}
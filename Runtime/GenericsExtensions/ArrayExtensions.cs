using UnityEngine;

namespace GenericsExtensions
{
	public static class ArrayExtensions
	{
		/// <summary>
		/// Sets every element in an <see cref="array"/> to a given <see cref="value"/>
		/// </summary>
		public static void Populate<T>(this T[] array, T value)
		{
			for (int i = 0; i < array.Length; i++) 
				array[i] = value;
		}

		/// <summary>
		/// Returns a random element from an <see cref="array"/>. Note: this uses Unity's <see cref="Random"/> class
		/// so if you're using a random seed to create deterministic randomness, this method may not be appropriate.  
		/// </summary>
		public static T GetRandom<T>(this T[] array)
		{
			return array[Random.Range(0, array.Length)];
		}
	}
}
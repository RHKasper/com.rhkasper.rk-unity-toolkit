using UnityEngine;

namespace MathExtensions
{
	/// <summary>
	/// This class contains constants for many common math calculations. These can be used for convenience,
	/// and to improve performance by avoiding recalculations. 
	/// </summary>
	public static class MathConstants
	{
		public static readonly float Pi = Mathf.PI;
		public static readonly float E = 2.7182818284f;
		
		public static readonly float Sqrt2 = 1.41421356237f;
		public static readonly float Sqrt3 = 1.73205080757f;
		public static readonly float Sqrt2Over2 = 0.70710678118f;
		public static readonly float Sqrt3Over2 = 0.86602540378f;
	}
}
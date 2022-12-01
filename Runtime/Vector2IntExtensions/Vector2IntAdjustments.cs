using System;
using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector2IntExtensions
{
	public static class Vector2IntAdjustments
	{
		/// <summary>
		/// Returns a new Vector2Int from the absolute value of each component of <see cref="v"/>
		/// </summary>
		[Pure] public static Vector2Int Abs(this Vector2Int v) => new Vector2Int(Mathf.Abs(v.x), Mathf.Abs(v.y));

		/// <summary>
		/// Returns a new Vector2Int where non-zero values get replaced with 1
		/// </summary>
		[Pure] public static Vector2Int Digitize(this Vector2Int v) => new Vector2Int(v.x == 0 ? 0 : 1, v.y == 0 ? 0 : 1);
		
		/// <summary>
		/// Returns a new Vector2Int with the greatest x value and the greatest y value from the given vectors.
		/// </summary>
		[Pure] public static Vector2Int Max(this Vector2Int v, Vector2Int v2) =>
			new Vector2Int(Mathf.Max(v.x, v2.x), Mathf.Max(v.y, v2.y));
		
		/// <summary>
		/// Returns a new Vector2Int with the least x value and the least y value from the given vectors.
		/// </summary>
		[Pure] public static Vector2Int Min(this Vector2Int v, Vector2Int v2) =>
			new Vector2Int(Mathf.Min(v.x, v2.x), Mathf.Min(v.y, v2.y));
		
		/// <summary>
		/// Returns the value of the greatest component of this Vector2Int
		/// </summary>
		[Pure] public static float MaxComponent(this Vector2Int v) => Mathf.Max(v.x, v.y);
		
		/// <summary>
		/// Returns the value of the least component of this Vector2Int
		/// </summary>
		[Pure] public static float MinComponent(this Vector2Int v) => Mathf.Min(v.x, v.y);
	
		/// <summary>
		/// Returns a new Vector2Int containing the sign of each component. Positive numbers return 1, zero returns 0, and negative numbers return -1
		/// </summary>
		[Pure] public static Vector2Int Sign(this Vector2Int v) => new Vector2Int(Math.Sign(v.x), Math.Sign(v.y));
	}
}
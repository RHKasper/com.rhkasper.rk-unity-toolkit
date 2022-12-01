using System;
using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector2Extensions
{
	public static class Vector2Adjustments
	{
		/// <summary>
		/// Returns a new Vector2 from the absolute value of each component of <see cref="v"/>
		/// </summary>
		[Pure] public static Vector2 Abs(this Vector2 v) => new Vector2(Mathf.Abs(v.x), Mathf.Abs(v.y));
		
		/// <summary>
		/// Returns a new Vector2 with each component clamped between the corresponding values of <see cref="min"/> and <see cref="max"/>
		/// </summary>
		[Pure] public static Vector2 Clamp(this Vector2 v, Vector2 min, Vector2 max) =>
			new Vector2(Mathf.Clamp(v.x, min.x, max.x), Mathf.Clamp(v.y, min.y, max.y));
		
		/// <summary>
		/// Returns a new Vector2 where non-zero values get replaced with 1
		/// </summary>
		[Pure] public static Vector2 Digitize(this Vector2 v) => new Vector2(v.x == 0 ? 0 : 1, v.y == 0 ? 0 : 1);
		
		/// <summary>
		/// Returns a new Vector2 with the greatest x value and the greatest y value from the given vectors.
		/// </summary>
		[Pure] public static Vector2 Max(this Vector2 v, Vector2 v2) => new Vector2(Mathf.Max(v.x, v2.x), Mathf.Max(v.y, v2.y));
		
		/// <summary>
		/// Returns a new Vector2 with the least x value and the least y value from the given vectors.
		/// </summary>
		[Pure] public static Vector2 Min(this Vector2 v, Vector2 v2) => new Vector2(Mathf.Min(v.x, v2.x), Mathf.Min(v.y, v2.y));
		
		/// <summary>
		/// Returns the value of the greatest component of this Vector2
		/// </summary>
		[Pure] public static float MaxComponent(this Vector2 v) => Mathf.Max(v.x, v.y);
		
		/// <summary>
		/// Returns the value of the least component of this Vector2
		/// </summary>
		[Pure] public static float MinComponent(this Vector2 v) => Mathf.Min(v.x, v.y);
	
		/// <summary>
		/// Returns a new Vector2 containing the sign of each component. Positive numbers return 1, zero returns 0, and negative numbers return -1
		/// </summary>
		[Pure] public static Vector2 Sign(this Vector2 v) => new Vector2(Math.Sign(v.x), Math.Sign(v.y));
	}
}
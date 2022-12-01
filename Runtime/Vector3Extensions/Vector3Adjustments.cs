using System;
using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector3Extensions
{
	public static class Vector3Adjustments
	{
		/// <summary>
		/// Returns a new Vector3 from the absolute value of each component of <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3 Abs(this Vector3 v) => new Vector3(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));
		
		/// <summary>
		/// Returns a new Vector3 with each component clamped between the corresponding values of <see cref="min"/> and <see cref="max"/>
		/// </summary>
		[Pure] public static Vector3 Clamp(this Vector3 v, Vector3 min, Vector3 max) =>
			new Vector3(Mathf.Clamp(v.x, min.x, max.x), Mathf.Clamp(v.y, min.y, max.y), Mathf.Clamp(v.z, min.z, max.z));
		
		/// <summary>
		/// Returns a new Vector3 where non-zero values get replaced with 1
		/// </summary>
		[Pure] public static Vector3 Digitize(this Vector3 v) => new Vector3(v.x == 0 ? 0 : 1, v.y == 0 ? 0 : 1, v.z == 0 ? 0 : 1);
		
		/// <summary>
		/// Returns a new Vector3 with the greatest x value, greatest y value, and greatest z value from the two vectors passed in.
		/// </summary>
		[Pure] public static Vector3 Max(this Vector3 v, Vector3 v2) => new Vector3(Mathf.Max(v.x, v2.x), Mathf.Max(v.y, v2.y), Mathf.Max(v.z, v2.z));
		
		/// <summary>
		/// Returns a new Vector3 with the least x value, least y value, and least z value from the two vectors passed in.
		/// </summary>
		[Pure] public static Vector3 Min(this Vector3 v, Vector3 v2) => new Vector3(Mathf.Min(v.x, v2.x), Mathf.Min(v.y, v2.y), Mathf.Min(v.z, v2.z));
		
		/// <summary>
		/// Returns the value of the greatest component of this Vector3
		/// </summary>
		[Pure] public static float MaxComponent(this Vector3 v)
		{
			// Use if-else instead of Mathf.Max(v.x, v.y, v.z,) to avoid allocating memory to a new params array
			if(v.x > v.y)
				return Mathf.Max(v.x, v.z);
			else
				return Mathf.Max(v.y, v.z);
		}

		/// <summary>
		/// Returns the value of the least component of this Vector3
		/// </summary>
		[Pure] public static float MinComponent(this Vector3 v)
		{			
			// Use if-else instead of Mathf.Min(v.x, v.y, v.z,) to avoid allocating memory to a new params array
			if(v.x < v.y)
				return Mathf.Min(v.x, v.z);
			else
				return Mathf.Min(v.y, v.z);
		}

		/// <summary>
		/// Returns a new Vector3 containing the sign of each component. Positive numbers return 1, zero returns 0, and negative numbers return -1
		/// </summary>
		[Pure] public static Vector3 Sign(this Vector3 v) => new Vector3(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z));
	}
}
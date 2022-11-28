using System;
using UnityEngine;

namespace Vector3IntExtensions
{
	public static class Vector3IntAdjustments
	{
		/// <summary>
		/// Returns a new Vector3Int from the absolute value of each component of <see cref="v"/>
		/// </summary>
		public static Vector3Int Abs(this Vector3Int v) =>
			new Vector3Int(Mathf.Abs(v.x), Mathf.Abs(v.y), Mathf.Abs(v.z));

		/// <summary>
		/// Returns a new Vector3Int where non-zero values get replaced with 1
		/// </summary>
		public static Vector3Int Digitize(this Vector3Int v) => new Vector3Int(v.x == 0 ? 0 : 1, v.y == 0 ? 0 : 1, v.z == 0 ? 0 : 1);
		
		/// <summary>
		/// Returns a new Vector3Int with the greatest x value, greatest y value, and greatest z value from the two vectors passed in.
		/// </summary>
		public static Vector3Int Max(this Vector3Int v, Vector3Int v2) => new Vector3Int(Mathf.Max(v.x, v2.x), Mathf.Max(v.y, v2.y), Mathf.Max(v.z, v2.z));
		
		/// <summary>
		/// Returns a new Vector3Int with the least x value, least y value, and least z value from the two vectors passed in.
		/// </summary>
		public static Vector3Int Min(this Vector3Int v, Vector3Int v2) => new Vector3Int(Mathf.Min(v.x, v2.x), Mathf.Min(v.y, v2.y), Mathf.Min(v.z, v2.z));
		
		/// <summary>
		/// Returns the value of the greatest component of this Vector3Int
		/// </summary>
		public static float MaxComponent(this Vector3Int v)
		{
			// Use if-else instead of Mathf.Max(v.x, v.y, v.z,) to avoid allocating memory to a new params array
			if(v.x > v.y)
				return Mathf.Max(v.x, v.z);
			else
				return Mathf.Max(v.y, v.z);
		}

		/// <summary>
		/// Returns the value of the least component of this Vector3Int
		/// </summary>
		public static float MinComponent(this Vector3Int v)
		{			
			// Use if-else instead of Mathf.Min(v.x, v.y, v.z,) to avoid allocating memory to a new params array
			if(v.x < v.y)
				return Mathf.Min(v.x, v.z);
			else
				return Mathf.Min(v.y, v.z);
		}

		/// <summary>
		/// Returns a new Vector3Int containing the sign of each component. Positive numbers return 1, zero returns 0, and negative numbers return -1
		/// </summary>
		public static Vector3Int Sign(this Vector3Int v) =>
			new Vector3Int(Math.Sign(v.x), Math.Sign(v.y), Math.Sign(v.z));
	}
}
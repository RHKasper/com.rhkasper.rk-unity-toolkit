using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector3Extensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector3 that allow you to convert to a Vector2 with components arranged however you like
	/// </summary>
	public static class Vector3ToVector2
	{
		/// <summary>
		/// Returns a new Vector2 with value (0, v.x) 
		/// </summary>
		[Pure] public static Vector2 OX(this Vector3 v) => new Vector2(0, v.x);
		
		/// <summary>
		/// Returns a new Vector2 with value (0, v.y) 
		/// </summary>
		[Pure] public static Vector2 OY(this Vector3 v) => new Vector2(0, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with value (0, v.z) 
		/// </summary>
		[Pure] public static Vector2 OZ(this Vector3 v) => new Vector2(0, v.z);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.x, 0) 
		/// </summary>
		[Pure] public static Vector2 XO(this Vector3 v) => new Vector2(v.x, 0);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.x, v.x) 
		/// </summary>
		[Pure] public static Vector2 XX(this Vector3 v) => new Vector2(v.x, v.x);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.x, v.x) 
		/// </summary>
		[Pure] public static Vector2 XY(this Vector3 v) => new Vector2(v.x, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.x, v.z) 
		/// </summary>
		[Pure] public static Vector2 XZ(this Vector3 v) => new Vector2(v.x, v.z);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.y, 0) 
		/// </summary>
		[Pure] public static Vector2 YO(this Vector3 v) => new Vector2(v.y, 0);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.y, v.x) 
		/// </summary>
		[Pure] public static Vector2 YX(this Vector3 v) => new Vector2(v.y, v.x);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.y, v.y) 
		/// </summary>
		[Pure] public static Vector2 YY(this Vector3 v) => new Vector2(v.y, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.y, v.z) 
		/// </summary>
		[Pure] public static Vector2 YZ(this Vector3 v) => new Vector2(v.y, v.z);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.z, 0) 
		/// </summary>
		[Pure] public static Vector2 ZO(this Vector3 v) => new Vector2(v.z, 0);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.z, v.x) 
		/// </summary>
		[Pure] public static Vector2 ZX(this Vector3 v) => new Vector2(v.z, v.x);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.z, v.y) 
		/// </summary>
		[Pure] public static Vector2 ZY(this Vector3 v) => new Vector2(v.z, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.z, v.z) 
		/// </summary>
		[Pure] public static Vector2 ZZ(this Vector3 v) => new Vector2(v.z, v.z);
	}
}
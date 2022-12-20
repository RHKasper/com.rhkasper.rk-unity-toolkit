using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector2Extensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector2 that allow you to convert to a Vector3 and rearrange or remove components.
	/// </summary>
	public static class Vector2ToVector3
	{
		/// <summary>
		/// Returns a new Vector3 with value (0, 0, v.x) 
		/// </summary>
		[Pure] public static Vector3 OOX(this Vector2 v) => new Vector3(0, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, 0, v.y) 
		/// </summary>
		[Pure] public static Vector3 OOY(this Vector2 v) => new Vector3(0, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.x, 0) 
		/// </summary>
		[Pure] public static Vector3 OXO(this Vector2 v) => new Vector3(0, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.x, v.x) 
		/// </summary>
		[Pure] public static Vector3 OXX(this Vector2 v) => new Vector3(0, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.x, v.y) 
		/// </summary>
		[Pure] public static Vector3 OXY(this Vector2 v) => new Vector3(0, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.y, 0) 
		/// </summary>
		[Pure] public static Vector3 OYO(this Vector2 v) => new Vector3(0, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.y, v.x) 
		/// </summary>
		[Pure] public static Vector3 OYX(this Vector2 v) => new Vector3(0, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.y, v.y) 
		/// </summary>
		[Pure] public static Vector3 OYY(this Vector2 v) => new Vector3(0, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, 0, 0) 
		/// </summary>
		[Pure] public static Vector3 XOO(this Vector2 v) => new Vector3(v.x, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, 0, v.x) 
		/// </summary>
		[Pure] public static Vector3 XOX(this Vector2 v) => new Vector3(v.x, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, 0, v.y) 
		/// </summary>
		[Pure] public static Vector3 XOY(this Vector2 v) => new Vector3(v.x, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.x, 0) 
		/// </summary>
		[Pure] public static Vector3 XXO(this Vector2 v) => new Vector3(v.x, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.x, v.x) 
		/// </summary>
		[Pure] public static Vector3 XXX(this Vector2 v) => new Vector3(v.x, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.x, v.y) 
		/// </summary>
		[Pure] public static Vector3 XXY(this Vector2 v) => new Vector3(v.x, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.y, 0) 
		/// </summary>
		[Pure] public static Vector3 XYO(this Vector2 v) => new Vector3(v.x, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.y, v.x) 
		/// </summary>
		[Pure] public static Vector3 XYX(this Vector2 v) => new Vector3(v.x, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.y, v.y) 
		/// </summary>
		[Pure] public static Vector3 XYY(this Vector2 v) => new Vector3(v.x, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, 0, 0) 
		/// </summary>
		[Pure] public static Vector3 YOO(this Vector2 v) => new Vector3(v.y, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, 0, v.x) 
		/// </summary>
		[Pure] public static Vector3 YOX(this Vector2 v) => new Vector3(v.y, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, 0, v.y) 
		/// </summary>
		[Pure] public static Vector3 YOY(this Vector2 v) => new Vector3(v.y, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.x, 0) 
		/// </summary>
		[Pure] public static Vector3 YXO(this Vector2 v) => new Vector3(v.y, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.x, v.x) 
		/// </summary>
		[Pure] public static Vector3 YXX(this Vector2 v) => new Vector3(v.y, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.x, v.y) 
		/// </summary>
		[Pure] public static Vector3 YXY(this Vector2 v) => new Vector3(v.y, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.y, 0) 
		/// </summary>
		[Pure] public static Vector3 YYO(this Vector2 v) => new Vector3(v.y, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.y, v.x) 
		/// </summary>
		[Pure] public static Vector3 YYX(this Vector2 v) => new Vector3(v.y, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.y, v.y) 
		/// </summary>
		[Pure] public static Vector3 YYY(this Vector2 v) => new Vector3(v.y, v.y, v.y);
	}
}
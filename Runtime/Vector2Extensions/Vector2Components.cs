using UnityEngine;

namespace Vector2Extensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector2 that allow you to rearrange or remove components of a Vector2.
	/// </summary>
	public static class Vector2Components
	{
		/// <summary>
		/// Returns a new Vector2 with value (0, v.x) 
		/// </summary>
		public static Vector2 OX(this Vector2 v) => new Vector2(0, v.x);
		
		/// <summary>
		/// Returns a new Vector2 with value (0, v.y) 
		/// </summary>
		public static Vector2 OY(this Vector2 v) => new Vector2(0, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.x, 0) 
		/// </summary>
		public static Vector2 XO(this Vector2 v) => new Vector2(v.x, 0);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.x, v.x) 
		/// </summary>
		public static Vector2 XX(this Vector2 v) => new Vector2(v.x, v.x);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.y, 0) 
		/// </summary>
		public static Vector2 YO(this Vector2 v) => new Vector2(v.y, 0);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.y, v.x) 
		/// </summary>
		public static Vector2 YX(this Vector2 v) => new Vector2(v.y, v.x);
		
		/// <summary>
		/// Returns a new Vector2 with value (v.y, v.y) 
		/// </summary>
		public static Vector2 YY(this Vector2 v) => new Vector2(v.y, v.y);
	}
}
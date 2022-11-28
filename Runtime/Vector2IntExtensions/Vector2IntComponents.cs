using UnityEngine;

namespace Vector2IntExtensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector2Int that allow you to rearrange or remove components of a Vector2Int.
	/// </summary>
	public static class Vector2IntComponents
	{
		/// <summary>
		/// Returns a new Vector2Int with value (0, v.x) 
		/// </summary>
		public static Vector2Int OX(this Vector2Int v) => new Vector2Int(0, v.x);
		
		/// <summary>
		/// Returns a new Vector2Int with value (0, v.y) 
		/// </summary>
		public static Vector2Int OY(this Vector2Int v) => new Vector2Int(0, v.y);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.x, 0) 
		/// </summary>
		public static Vector2Int XO(this Vector2Int v) => new Vector2Int(v.x, 0);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.x, v.x) 
		/// </summary>
		public static Vector2Int XX(this Vector2Int v) => new Vector2Int(v.x, v.x);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.y, 0) 
		/// </summary>
		public static Vector2Int YO(this Vector2Int v) => new Vector2Int(v.y, 0);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.y, v.x) 
		/// </summary>
		public static Vector2Int YX(this Vector2Int v) => new Vector2Int(v.y, v.x);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.y, v.y) 
		/// </summary>
		public static Vector2Int YY(this Vector2Int v) => new Vector2Int(v.y, v.y);
	}
}
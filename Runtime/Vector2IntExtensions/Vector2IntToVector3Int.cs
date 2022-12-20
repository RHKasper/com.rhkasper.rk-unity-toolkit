using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector2IntExtensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector2Int that allow you to convert to a Vector3Int and rearrange or remove components.
	/// </summary>
	public static class Vector2IntToVector3Int
	{
		/// <summary>
		/// Returns a new Vector3Int with value (0, 0, v.x) 
		/// </summary>
		[Pure] public static Vector3Int OOX(this Vector2Int v) => new Vector3Int(0, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, 0, v.y) 
		/// </summary>
		[Pure] public static Vector3Int OOY(this Vector2Int v) => new Vector3Int(0, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.x, 0) 
		/// </summary>
		[Pure] public static Vector3Int OXO(this Vector2Int v) => new Vector3Int(0, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.x, v.x) 
		/// </summary>
		[Pure] public static Vector3Int OXX(this Vector2Int v) => new Vector3Int(0, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.x, v.y) 
		/// </summary>
		[Pure] public static Vector3Int OXY(this Vector2Int v) => new Vector3Int(0, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.y, 0) 
		/// </summary>
		[Pure] public static Vector3Int OYO(this Vector2Int v) => new Vector3Int(0, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.y, v.x) 
		/// </summary>
		[Pure] public static Vector3Int OYX(this Vector2Int v) => new Vector3Int(0, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.y, v.y) 
		/// </summary>
		[Pure] public static Vector3Int OYY(this Vector2Int v) => new Vector3Int(0, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, 0, 0) 
		/// </summary>
		[Pure] public static Vector3Int XOO(this Vector2Int v) => new Vector3Int(v.x, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, 0, v.x) 
		/// </summary>
		[Pure] public static Vector3Int XOX(this Vector2Int v) => new Vector3Int(v.x, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, 0, v.y) 
		/// </summary>
		[Pure] public static Vector3Int XOY(this Vector2Int v) => new Vector3Int(v.x, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.x, 0) 
		/// </summary>
		[Pure] public static Vector3Int XXO(this Vector2Int v) => new Vector3Int(v.x, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.x, v.x) 
		/// </summary>
		[Pure] public static Vector3Int XXX(this Vector2Int v) => new Vector3Int(v.x, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.x, v.y) 
		/// </summary>
		[Pure] public static Vector3Int XXY(this Vector2Int v) => new Vector3Int(v.x, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.y, 0) 
		/// </summary>
		[Pure] public static Vector3Int XYO(this Vector2Int v) => new Vector3Int(v.x, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.y, v.x) 
		/// </summary>
		[Pure] public static Vector3Int XYX(this Vector2Int v) => new Vector3Int(v.x, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.y, v.y) 
		/// </summary>
		[Pure] public static Vector3Int XYY(this Vector2Int v) => new Vector3Int(v.x, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, 0, 0) 
		/// </summary>
		[Pure] public static Vector3Int YOO(this Vector2Int v) => new Vector3Int(v.y, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, 0, v.x) 
		/// </summary>
		[Pure] public static Vector3Int YOX(this Vector2Int v) => new Vector3Int(v.y, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, 0, v.y) 
		/// </summary>
		[Pure] public static Vector3Int YOY(this Vector2Int v) => new Vector3Int(v.y, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.x, 0) 
		/// </summary>
		[Pure] public static Vector3Int YXO(this Vector2Int v) => new Vector3Int(v.y, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.x, v.x) 
		/// </summary>
		[Pure] public static Vector3Int YXX(this Vector2Int v) => new Vector3Int(v.y, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.x, v.y) 
		/// </summary>
		[Pure] public static Vector3Int YXY(this Vector2Int v) => new Vector3Int(v.y, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.y, 0) 
		/// </summary>
		[Pure] public static Vector3Int YYO(this Vector2Int v) => new Vector3Int(v.y, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.y, v.x) 
		/// </summary>
		[Pure] public static Vector3Int YYX(this Vector2Int v) => new Vector3Int(v.y, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.y, v.y) 
		/// </summary>
		[Pure] public static Vector3Int YYY(this Vector2Int v) => new Vector3Int(v.y, v.y, v.y);
	}
}
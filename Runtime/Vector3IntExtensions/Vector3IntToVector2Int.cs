using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector3IntExtensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector3Int that allow you to convert to a Vector2Int with components arranged however you like
	/// </summary>
	public static class Vector3IntToVector2Int
	{
		/// <summary>
		/// Returns a new Vector2Int with value (0, v.x) 
		/// </summary>
		[Pure] public static Vector2Int OX(this Vector3Int v) => new Vector2Int(0, v.x);
		
		/// <summary>
		/// Returns a new Vector2Int with value (0, v.y) 
		/// </summary>
		[Pure] public static Vector2Int OY(this Vector3Int v) => new Vector2Int(0, v.y);
		
		/// <summary>
		/// Returns a new Vector2Int with value (0, v.z) 
		/// </summary>
		[Pure] public static Vector2Int OZ(this Vector3Int v) => new Vector2Int(0, v.z);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.x, 0) 
		/// </summary>
		[Pure] public static Vector2Int XO(this Vector3Int v) => new Vector2Int(v.x, 0);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.x, v.x) 
		/// </summary>
		[Pure] public static Vector2Int XX(this Vector3Int v) => new Vector2Int(v.x, v.x);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.x, v.x) 
		/// </summary>
		[Pure] public static Vector2Int XY(this Vector3Int v) => new Vector2Int(v.x, v.y);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.x, v.z) 
		/// </summary>
		[Pure] public static Vector2Int XZ(this Vector3Int v) => new Vector2Int(v.x, v.z);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.y, 0) 
		/// </summary>
		[Pure] public static Vector2Int YO(this Vector3Int v) => new Vector2Int(v.y, 0);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.y, v.x) 
		/// </summary>
		[Pure] public static Vector2Int YX(this Vector3Int v) => new Vector2Int(v.y, v.x);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.y, v.y) 
		/// </summary>
		[Pure] public static Vector2Int YY(this Vector3Int v) => new Vector2Int(v.y, v.y);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.y, v.z) 
		/// </summary>
		[Pure] public static Vector2Int YZ(this Vector3Int v) => new Vector2Int(v.y, v.z);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.z, 0) 
		/// </summary>
		[Pure] public static Vector2Int ZO(this Vector3Int v) => new Vector2Int(v.z, 0);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.z, v.x) 
		/// </summary>
		[Pure] public static Vector2Int ZX(this Vector3Int v) => new Vector2Int(v.z, v.x);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.z, v.y) 
		/// </summary>
		[Pure] public static Vector2Int ZY(this Vector3Int v) => new Vector2Int(v.z, v.y);
		
		/// <summary>
		/// Returns a new Vector2Int with value (v.z, v.z) 
		/// </summary>
		[Pure] public static Vector2Int ZZ(this Vector3Int v) => new Vector2Int(v.z, v.z);
	}
}
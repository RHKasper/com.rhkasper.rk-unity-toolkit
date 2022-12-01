using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector3IntExtensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector3Int that allow you to rearrange or remove components of a Vector3Int.
	/// </summary>
	public static class Vector3IntComponents
	{
		/// <summary>
		/// Returns a new Vector3Int with value (0, 0, v.x) 
		/// </summary>
		[Pure] public static Vector3Int OOX(this Vector3Int v) => new Vector3Int(0, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, 0, v.y) 
		/// </summary>
		[Pure] public static Vector3Int OOY(this Vector3Int v) => new Vector3Int(0, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, 0, v.z) 
		/// </summary>
		[Pure] public static Vector3Int OOZ(this Vector3Int v) => new Vector3Int(0, 0, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.x, 0) 
		/// </summary>
		[Pure] public static Vector3Int OXO(this Vector3Int v) => new Vector3Int(0, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.x, v.x) 
		/// </summary>
		[Pure] public static Vector3Int OXX(this Vector3Int v) => new Vector3Int(0, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.x, v.y) 
		/// </summary>
		[Pure] public static Vector3Int OXY(this Vector3Int v) => new Vector3Int(0, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.x, v.z) 
		/// </summary>
		[Pure] public static Vector3Int OXZ(this Vector3Int v) => new Vector3Int(0, v.x, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.y, 0) 
		/// </summary>
		[Pure] public static Vector3Int OYO(this Vector3Int v) => new Vector3Int(0, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.y, v.x) 
		/// </summary>
		[Pure] public static Vector3Int OYX(this Vector3Int v) => new Vector3Int(0, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.y, v.y) 
		/// </summary>
		[Pure] public static Vector3Int OYY(this Vector3Int v) => new Vector3Int(0, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.y, v.z) 
		/// </summary>
		[Pure] public static Vector3Int OYZ(this Vector3Int v) => new Vector3Int(0, v.y, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.z, 0) 
		/// </summary>
		[Pure] public static Vector3Int OZO(this Vector3Int v) => new Vector3Int(0, v.z, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.z, v.x) 
		/// </summary>
		[Pure] public static Vector3Int OZX(this Vector3Int v) => new Vector3Int(0, v.z, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.z, v.y) 
		/// </summary>
		[Pure] public static Vector3Int OZY(this Vector3Int v) => new Vector3Int(0, v.z, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (0, v.z, v.z) 
		/// </summary>
		[Pure] public static Vector3Int OZZ(this Vector3Int v) => new Vector3Int(0, v.z, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, 0, 0) 
		/// </summary>
		[Pure] public static Vector3Int XOO(this Vector3Int v) => new Vector3Int(v.x, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, 0, v.x) 
		/// </summary>
		[Pure] public static Vector3Int XOX(this Vector3Int v) => new Vector3Int(v.x, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, 0, v.y) 
		/// </summary>
		[Pure] public static Vector3Int XOY(this Vector3Int v) => new Vector3Int(v.x, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, 0, v.z) 
		/// </summary>
		[Pure] public static Vector3Int XOZ(this Vector3Int v) => new Vector3Int(v.x, 0, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.x, 0) 
		/// </summary>
		[Pure] public static Vector3Int XXO(this Vector3Int v) => new Vector3Int(v.x, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.x, v.x) 
		/// </summary>
		[Pure] public static Vector3Int XXX(this Vector3Int v) => new Vector3Int(v.x, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.x, v.y) 
		/// </summary>
		[Pure] public static Vector3Int XXY(this Vector3Int v) => new Vector3Int(v.x, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.x, v.z) 
		/// </summary>
		[Pure] public static Vector3Int XXZ(this Vector3Int v) => new Vector3Int(v.x, v.x, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.y, 0) 
		/// </summary>
		[Pure] public static Vector3Int XYO(this Vector3Int v) => new Vector3Int(v.x, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.y, v.x) 
		/// </summary>
		[Pure] public static Vector3Int XYX(this Vector3Int v) => new Vector3Int(v.x, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.y, v.y) 
		/// </summary>
		[Pure] public static Vector3Int XYY(this Vector3Int v) => new Vector3Int(v.x, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.z, 0) 
		/// </summary>
		[Pure] public static Vector3Int XZO(this Vector3Int v) => new Vector3Int(v.x, v.z, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.z, v.x) 
		/// </summary>
		[Pure] public static Vector3Int XZX(this Vector3Int v) => new Vector3Int(v.x, v.z, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.z, v.y) 
		/// </summary>
		[Pure] public static Vector3Int XZY(this Vector3Int v) => new Vector3Int(v.x, v.z, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.x, v.z, v.z) 
		/// </summary>
		[Pure] public static Vector3Int XZZ(this Vector3Int v) => new Vector3Int(v.x, v.z, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, 0, 0) 
		/// </summary>
		public static Vector3Int YOO(this Vector3Int v) => new Vector3Int(v.y, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, 0, v.x) 
		/// </summary>
		public static Vector3Int YOX(this Vector3Int v) => new Vector3Int(v.y, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, 0, v.y) 
		/// </summary>
		public static Vector3Int YOY(this Vector3Int v) => new Vector3Int(v.y, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, 0, v.z) 
		/// </summary>
		public static Vector3Int YOZ(this Vector3Int v) => new Vector3Int(v.y, 0, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.x, 0) 
		/// </summary>
		public static Vector3Int YXO(this Vector3Int v) => new Vector3Int(v.y, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.x, v.x) 
		/// </summary>
		public static Vector3Int YXX(this Vector3Int v) => new Vector3Int(v.y, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.x, v.y) 
		/// </summary>
		public static Vector3Int YXY(this Vector3Int v) => new Vector3Int(v.y, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.x, v.z) 
		/// </summary>
		public static Vector3Int YXZ(this Vector3Int v) => new Vector3Int(v.y, v.x, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.y, 0) 
		/// </summary>
		public static Vector3Int YYO(this Vector3Int v) => new Vector3Int(v.y, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.y, v.x) 
		/// </summary>
		public static Vector3Int YYX(this Vector3Int v) => new Vector3Int(v.y, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.y, v.y) 
		/// </summary>
		public static Vector3Int YYY(this Vector3Int v) => new Vector3Int(v.y, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.y, v.z) 
		/// </summary>
		public static Vector3Int YYZ(this Vector3Int v) => new Vector3Int(v.y, v.y, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.z, 0) 
		/// </summary>
		public static Vector3Int YZO(this Vector3Int v) => new Vector3Int(v.y, v.z, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.z, v.x) 
		/// </summary>
		public static Vector3Int YZX(this Vector3Int v) => new Vector3Int(v.y, v.z, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.z, v.y) 
		/// </summary>
		public static Vector3Int YZY(this Vector3Int v) => new Vector3Int(v.y, v.z, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.y, v.z, v.z) 
		/// </summary>
		public static Vector3Int YZZ(this Vector3Int v) => new Vector3Int(v.y, v.z, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, 0, 0) 
		/// </summary>
		public static Vector3Int ZOO(this Vector3Int v) => new Vector3Int(v.z, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, 0, v.x) 
		/// </summary>
		public static Vector3Int ZOX(this Vector3Int v) => new Vector3Int(v.z, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, 0, v.y) 
		/// </summary>
		public static Vector3Int ZOY(this Vector3Int v) => new Vector3Int(v.z, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, 0, v.z) 
		/// </summary>
		public static Vector3Int ZOZ(this Vector3Int v) => new Vector3Int(v.z, 0, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.x, 0) 
		/// </summary>
		public static Vector3Int ZXO(this Vector3Int v) => new Vector3Int(v.z, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.x, v.x) 
		/// </summary>
		public static Vector3Int ZXX(this Vector3Int v) => new Vector3Int(v.z, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.x, v.y) 
		/// </summary>
		public static Vector3Int ZXY(this Vector3Int v) => new Vector3Int(v.z, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.x, v.z) 
		/// </summary>
		public static Vector3Int ZXZ(this Vector3Int v) => new Vector3Int(v.z, v.x, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.y, 0) 
		/// </summary>
		public static Vector3Int ZYO(this Vector3Int v) => new Vector3Int(v.z, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.y, v.x) 
		/// </summary>
		public static Vector3Int ZYX(this Vector3Int v) => new Vector3Int(v.z, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.y, v.y) 
		/// </summary>
		public static Vector3Int ZYY(this Vector3Int v) => new Vector3Int(v.z, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.y, v.z) 
		/// </summary>
		public static Vector3Int ZYZ(this Vector3Int v) => new Vector3Int(v.z, v.y, v.z);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.z, 0) 
		/// </summary>
		public static Vector3Int ZZO(this Vector3Int v) => new Vector3Int(v.z, v.z, 0);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.z, v.x) 
		/// </summary>
		public static Vector3Int ZZX(this Vector3Int v) => new Vector3Int(v.z, v.z, v.x);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.z, v.y) 
		/// </summary>
		public static Vector3Int ZZY(this Vector3Int v) => new Vector3Int(v.z, v.z, v.y);
				
		/// <summary>
		/// Returns a new Vector3Int with value (v.z, v.z, v.z) 
		/// </summary>
		public static Vector3Int ZZZ(this Vector3Int v) => new Vector3Int(v.z, v.z, v.z);
	}
}
using UnityEngine;

namespace Vector3Extensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector3 that allow you to rearrange or remove components of a Vector3.
	/// </summary>
	public static class Vector3Components
	{
		/// <summary>
		/// Returns a new Vector3 with value (0, 0, v.x) 
		/// </summary>
		public static Vector3 OOX(this Vector3 v) => new Vector3(0, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, 0, v.y) 
		/// </summary>
		public static Vector3 OOY(this Vector3 v) => new Vector3(0, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, 0, v.z) 
		/// </summary>
		public static Vector3 OOZ(this Vector3 v) => new Vector3(0, 0, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.x, 0) 
		/// </summary>
		public static Vector3 OXO(this Vector3 v) => new Vector3(0, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.x, v.x) 
		/// </summary>
		public static Vector3 OXX(this Vector3 v) => new Vector3(0, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.x, v.y) 
		/// </summary>
		public static Vector3 OXY(this Vector3 v) => new Vector3(0, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.x, v.z) 
		/// </summary>
		public static Vector3 OXZ(this Vector3 v) => new Vector3(0, v.x, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.y, 0) 
		/// </summary>
		public static Vector3 OYO(this Vector3 v) => new Vector3(0, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.y, v.x) 
		/// </summary>
		public static Vector3 OYX(this Vector3 v) => new Vector3(0, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.y, v.y) 
		/// </summary>
		public static Vector3 OYY(this Vector3 v) => new Vector3(0, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.y, v.z) 
		/// </summary>
		public static Vector3 OYZ(this Vector3 v) => new Vector3(0, v.y, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.z, 0) 
		/// </summary>
		public static Vector3 OZO(this Vector3 v) => new Vector3(0, v.z, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.z, v.x) 
		/// </summary>
		public static Vector3 OZX(this Vector3 v) => new Vector3(0, v.z, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.z, v.y) 
		/// </summary>
		public static Vector3 OZY(this Vector3 v) => new Vector3(0, v.z, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (0, v.z, v.z) 
		/// </summary>
		public static Vector3 OZZ(this Vector3 v) => new Vector3(0, v.z, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, 0, 0) 
		/// </summary>
		public static Vector3 XOO(this Vector3 v) => new Vector3(v.x, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, 0, v.x) 
		/// </summary>
		public static Vector3 XOX(this Vector3 v) => new Vector3(v.x, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, 0, v.y) 
		/// </summary>
		public static Vector3 XOY(this Vector3 v) => new Vector3(v.x, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, 0, v.z) 
		/// </summary>
		public static Vector3 XOZ(this Vector3 v) => new Vector3(v.x, 0, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.x, 0) 
		/// </summary>
		public static Vector3 XXO(this Vector3 v) => new Vector3(v.x, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.x, v.x) 
		/// </summary>
		public static Vector3 XXX(this Vector3 v) => new Vector3(v.x, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.x, v.y) 
		/// </summary>
		public static Vector3 XXY(this Vector3 v) => new Vector3(v.x, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.x, v.z) 
		/// </summary>
		public static Vector3 XXZ(this Vector3 v) => new Vector3(v.x, v.x, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.y, 0) 
		/// </summary>
		public static Vector3 XYO(this Vector3 v) => new Vector3(v.x, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.y, v.x) 
		/// </summary>
		public static Vector3 XYX(this Vector3 v) => new Vector3(v.x, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.y, v.y) 
		/// </summary>
		public static Vector3 XYY(this Vector3 v) => new Vector3(v.x, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.z, 0) 
		/// </summary>
		public static Vector3 XZO(this Vector3 v) => new Vector3(v.x, v.z, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.z, v.x) 
		/// </summary>
		public static Vector3 XZX(this Vector3 v) => new Vector3(v.x, v.z, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.z, v.y) 
		/// </summary>
		public static Vector3 XZY(this Vector3 v) => new Vector3(v.x, v.z, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.x, v.z, v.z) 
		/// </summary>
		public static Vector3 XZZ(this Vector3 v) => new Vector3(v.x, v.z, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, 0, 0) 
		/// </summary>
		public static Vector3 YOO(this Vector3 v) => new Vector3(v.y, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, 0, v.x) 
		/// </summary>
		public static Vector3 YOX(this Vector3 v) => new Vector3(v.y, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, 0, v.y) 
		/// </summary>
		public static Vector3 YOY(this Vector3 v) => new Vector3(v.y, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, 0, v.z) 
		/// </summary>
		public static Vector3 YOZ(this Vector3 v) => new Vector3(v.y, 0, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.x, 0) 
		/// </summary>
		public static Vector3 YXO(this Vector3 v) => new Vector3(v.y, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.x, v.x) 
		/// </summary>
		public static Vector3 YXX(this Vector3 v) => new Vector3(v.y, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.x, v.y) 
		/// </summary>
		public static Vector3 YXY(this Vector3 v) => new Vector3(v.y, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.x, v.z) 
		/// </summary>
		public static Vector3 YXZ(this Vector3 v) => new Vector3(v.y, v.x, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.y, 0) 
		/// </summary>
		public static Vector3 YYO(this Vector3 v) => new Vector3(v.y, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.y, v.x) 
		/// </summary>
		public static Vector3 YYX(this Vector3 v) => new Vector3(v.y, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.y, v.y) 
		/// </summary>
		public static Vector3 YYY(this Vector3 v) => new Vector3(v.y, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.y, v.z) 
		/// </summary>
		public static Vector3 YYZ(this Vector3 v) => new Vector3(v.y, v.y, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.z, 0) 
		/// </summary>
		public static Vector3 YZO(this Vector3 v) => new Vector3(v.y, v.z, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.z, v.x) 
		/// </summary>
		public static Vector3 YZX(this Vector3 v) => new Vector3(v.y, v.z, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.z, v.y) 
		/// </summary>
		public static Vector3 YZY(this Vector3 v) => new Vector3(v.y, v.z, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.y, v.z, v.z) 
		/// </summary>
		public static Vector3 YZZ(this Vector3 v) => new Vector3(v.y, v.z, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, 0, 0) 
		/// </summary>
		public static Vector3 ZOO(this Vector3 v) => new Vector3(v.z, 0, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, 0, v.x) 
		/// </summary>
		public static Vector3 ZOX(this Vector3 v) => new Vector3(v.z, 0, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, 0, v.y) 
		/// </summary>
		public static Vector3 ZOY(this Vector3 v) => new Vector3(v.z, 0, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, 0, v.z) 
		/// </summary>
		public static Vector3 ZOZ(this Vector3 v) => new Vector3(v.z, 0, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.x, 0) 
		/// </summary>
		public static Vector3 ZXO(this Vector3 v) => new Vector3(v.z, v.x, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.x, v.x) 
		/// </summary>
		public static Vector3 ZXX(this Vector3 v) => new Vector3(v.z, v.x, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.x, v.y) 
		/// </summary>
		public static Vector3 ZXY(this Vector3 v) => new Vector3(v.z, v.x, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.x, v.z) 
		/// </summary>
		public static Vector3 ZXZ(this Vector3 v) => new Vector3(v.z, v.x, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.y, 0) 
		/// </summary>
		public static Vector3 ZYO(this Vector3 v) => new Vector3(v.z, v.y, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.y, v.x) 
		/// </summary>
		public static Vector3 ZYX(this Vector3 v) => new Vector3(v.z, v.y, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.y, v.y) 
		/// </summary>
		public static Vector3 ZYY(this Vector3 v) => new Vector3(v.z, v.y, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.y, v.z) 
		/// </summary>
		public static Vector3 ZYZ(this Vector3 v) => new Vector3(v.z, v.y, v.z);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.z, 0) 
		/// </summary>
		public static Vector3 ZZO(this Vector3 v) => new Vector3(v.z, v.z, 0);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.z, v.x) 
		/// </summary>
		public static Vector3 ZZX(this Vector3 v) => new Vector3(v.z, v.z, v.x);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.z, v.y) 
		/// </summary>
		public static Vector3 ZZY(this Vector3 v) => new Vector3(v.z, v.z, v.y);
				
		/// <summary>
		/// Returns a new Vector3 with value (v.z, v.z, v.z) 
		/// </summary>
		public static Vector3 ZZZ(this Vector3 v) => new Vector3(v.z, v.z, v.z);
	}
}
using UnityEngine;

namespace Vector3IntExtensions
{
	public static class Vector3IntMultiply
	{
		/// <summary>
		/// Returns the component-wise product of two Vector3Int objects
		/// </summary>
		public static Vector3Int Multiply(this Vector3Int v1, Vector3Int v2) => new Vector3Int(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
		
		/// <summary>
		/// Returns the component-wise product of a Vector3Int and a Vector3
		/// </summary>
		public static Vector3 Multiply(this Vector3Int v1, Vector3 v2) => new Vector3(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
	}
}
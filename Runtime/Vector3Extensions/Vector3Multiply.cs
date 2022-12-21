using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector3Extensions
{
	public static class Vector3Multiply
	{
		/// <summary>
		/// Returns the component-wise product of two Vector3 objects
		/// </summary>
		[Pure] public static Vector3 Multiply(this Vector3 v1, Vector3 v2) => new Vector3(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
		
		/// <summary>
		/// Returns the component-wise product of a Vector3 and a Vector3Int
		/// </summary>
		[Pure] public static Vector3 Multiply(this Vector3 v1, Vector3Int v2) => new Vector3(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z);
	}
}
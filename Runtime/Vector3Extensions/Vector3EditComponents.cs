using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector3Extensions
{
	public static class Vector3EditComponents
	{
		/// <summary>
		/// Returns a new Vector3 with the given <see cref="x"/> value and the y and z values from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3 WithX(this Vector3 v, int x) => new Vector3(x, v.y, v.z);
		
		/// <summary>
		/// Returns a new Vector3 with the given <see cref="y"/> value and the x and z values from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3 WithY(this Vector3 v, int y) => new Vector3(v.x, y, v.z);
		
		/// <summary>
		/// Returns a new Vector3 with the given <see cref="z"/> value and the x and y values from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3 WithZ(this Vector3 v, int z) => new Vector3(v.x, v.y, z);
		
		
		/// <summary>
		/// Returns a new Vector3 with the given <see cref="x"/> and <see cref="y"/> values and the z value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3 WithXY(this Vector3 v, int x, int y) => new Vector3(x, y, v.z);
		
		/// <summary>
		/// Returns a new Vector3 with the given <see cref="x"/> and <see cref="z"/> values and the y value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3 WithXZ(this Vector3 v, int x, int z) => new Vector3(x, v.y, z);
		
		/// <summary>
		/// Returns a new Vector3 with the given <see cref="y"/> and <see cref="z"/> values and the x value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3 WithYZ(this Vector3 v, int y, int z) => new Vector3(v.x, y, z);
		
		
		/// <summary>
		/// Returns a new Vector3 with the x value of <see cref="v"/> negated, and the y and z values unchanged
		/// </summary>
		[Pure] public static Vector3 WithNegativeX(this Vector3 v) => new Vector3(-v.x, v.y, v.z);
		
		/// <summary>
		/// Returns a new Vector3 with the y value of <see cref="v"/> negated, and the x and z values unchanged
		/// </summary>
		[Pure] public static Vector3 WithNegativeY(this Vector3 v) => new Vector3(v.x, -v.y, v.z);
		
		/// <summary>
		/// Returns a new Vector3 with the z value of <see cref="v"/> negated, and the x and y values unchanged
		/// </summary>
		[Pure] public static Vector3 WithNegativeZ(this Vector3 v) => new Vector3(v.x, v.y, -v.z);
	}
}
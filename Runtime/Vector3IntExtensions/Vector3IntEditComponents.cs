using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector3IntExtensions
{
	public static class Vector3IntEditComponents
	{
		/// <summary>
		/// Returns a new Vector3Int with the given <see cref="x"/> value and the y and z values from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3Int WithX(this Vector3Int v, int x) => new Vector3Int(x, v.y, v.z);
		
		/// <summary>
		/// Returns a new Vector3Int with the given <see cref="y"/> value and the x and z values from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3Int WithY(this Vector3Int v, int y) => new Vector3Int(v.x, y, v.z);
		
		/// <summary>
		/// Returns a new Vector3Int with the given <see cref="z"/> value and the x and y values from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3Int WithZ(this Vector3Int v, int z) => new Vector3Int(v.x, v.y, z);
		
		
		/// <summary>
		/// Returns a new Vector3Int with the given <see cref="x"/> and <see cref="y"/> values and the z value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3Int WithXY(this Vector3Int v, int x, int y) => new Vector3Int(x, y, v.z);
		
		/// <summary>
		/// Returns a new Vector3Int with the given <see cref="x"/> and <see cref="z"/> values and the y value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector3Int WithXZ(this Vector3Int v, int x, int z) => new Vector3Int(x, v.y, z);
		
		/// <summary>
		/// Returns a new Vector3Int with the given <see cref="y"/> and <see cref="z"/> values and the x value from <see cref="v"/>
		/// </summary>
		public static Vector3Int WithYZ(this Vector3Int v, int y, int z) => new Vector3Int(v.x, y, z);
		
		/// <summary>
		/// Returns a new Vector3Int with the x value of <see cref="v"/> negated, and the y and z values unchanged
		/// </summary>
		public static Vector3Int WithNegativeX(this Vector3Int v) => new Vector3Int(-v.x, v.y, v.z);
		
		/// <summary>
		/// Returns a new Vector3Int with the y value of <see cref="v"/> negated, and the x and z values unchanged
		/// </summary>
		public static Vector3Int WithNegativeY(this Vector3Int v) => new Vector3Int(v.x, -v.y, v.z);
		
		/// <summary>
		/// Returns a new Vector3Int with the z value of <see cref="v"/> negated, and the x and y values unchanged
		/// </summary>
		public static Vector3Int WithNegativeZ(this Vector3Int v) => new Vector3Int(v.x, v.y, -v.z);
	}
}
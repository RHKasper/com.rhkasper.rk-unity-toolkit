using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector2IntExtensions
{
	public static class Vector2IntEditComponents
	{
		/// <summary>
		/// Returns a new Vector2 with the given <see cref="x"/> value and the y value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector2Int WithX(this Vector2Int v, int x) => new Vector2Int(x, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with the given <see cref="y"/> value and the x value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector2Int WithY(this Vector2Int v, int y) => new Vector2Int(v.x, y);
		
		/// <summary>
		/// Returns a new Vector2 with the x value of <see cref="v"/> negated, and the y value unchanged
		/// </summary>
		[Pure] public static Vector2Int WithNegativeX(this Vector2Int v) => new Vector2Int(-v.x, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with the y value of <see cref="v"/> negated, and the x value unchanged
		/// </summary>
		[Pure] public static Vector2Int WithNegativeY(this Vector2Int v) => new Vector2Int(v.x, -v.y);
	}
}
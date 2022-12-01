using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector2Extensions
{
	public static class Vector2EditComponents
	{
		/// <summary>
		/// Returns a new Vector2 with the given <see cref="x"/> value and the y value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector2 WithX(this Vector2 v, float x) => new Vector2(x, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with the given <see cref="y"/> value and the x value from <see cref="v"/>
		/// </summary>
		[Pure] public static Vector2 WithY(this Vector2 v, float y) => new Vector2(v.x, y);
		
		/// <summary>
		/// Returns a new Vector2 with the x value of <see cref="v"/> negated, and the y value unchanged
		/// </summary>
		[Pure] public static Vector2 WithNegativeX(this Vector2 v) => new Vector2(-v.x, v.y);
		
		/// <summary>
		/// Returns a new Vector2 with the y value of <see cref="v"/> negated, and the x value unchanged
		/// </summary>
		[Pure] public static Vector2 WithNegativeY(this Vector2 v) => new Vector2(v.x, -v.y);
	}
}
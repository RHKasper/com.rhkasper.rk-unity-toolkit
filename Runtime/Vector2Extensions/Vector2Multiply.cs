using System.Diagnostics.Contracts;
using UnityEngine;

namespace Vector2Extensions
{
	public static class Vector2Multiply
	{
		/// <summary>
		/// Returns the component-wise product of two Vector2 objects
		/// </summary>
		[Pure] public static Vector2 Multiply(this Vector2 v1, Vector2 v2) => new Vector2(v1.x * v2.x, v1.y * v2.y);
		
		/// <summary>
		/// Returns the component-wise product of a Vector2 and a Vector2Int
		/// </summary>
		[Pure] public static Vector2 Multiply(this Vector2 v1, Vector2Int v2) => new Vector2(v1.x * v2.x, v1.y * v2.y);
	}
}
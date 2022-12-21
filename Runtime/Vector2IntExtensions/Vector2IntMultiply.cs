using UnityEngine;

namespace Vector2IntExtensions
{
	public static class Vector2IntMultiply
	{
		/// <summary>
		/// Returns the component-wise product of two Vector2Int objects
		/// </summary>
		public static Vector2Int Multiply(this Vector2Int v1, Vector2Int v2) => new Vector2Int(v1.x * v2.x, v1.y * v2.y);
		
		/// <summary>
		/// Returns the component-wise product of a Vector2Int and a Vector2
		/// </summary>
		public static Vector2 Multiply(this Vector2Int v1, Vector2 v2) => new Vector2(v1.x * v2.x, v1.y * v2.y);
	}
}
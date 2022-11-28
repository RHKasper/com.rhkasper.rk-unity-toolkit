using UnityEngine;

namespace Vector2Extensions
{
	public static class Vector2Rounding
	{
		/// <summary>
		/// Returns a new Vector2 with the results of calling Mathf.Floor() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector2 Floor(this Vector2 v) => new Vector2(Mathf.Floor(v.x), Mathf.Floor(v.y));
		
		/// <summary>
		/// Returns a new Vector2Int with the results of calling Mathf.FloorToInt() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector2Int FloorToInt(this Vector2 v) =>
			new Vector2Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y));
		
		/// <summary>
		/// Returns a new Vector2 with the results of calling Mathf.Ceil() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector2 Ceil(this Vector2 v) => new Vector2(Mathf.Ceil(v.x), Mathf.Ceil(v.y));
		
		/// <summary>
		/// Returns a new Vector2Int with the results of calling Mathf.CeilToInt() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector2Int CeilToInt(this Vector2 v) => new Vector2Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y));
		
		/// <summary>
		/// Returns a new Vector2 with the results of calling Mathf.Round() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector2 Round(this Vector2 v) => new Vector2(Mathf.Round(v.x), Mathf.Round(v.y));
		
		/// <summary>
		/// Returns a new Vector2Int with the results of calling Mathf.RoundToInt) on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector2Int RoundToInt(this Vector2 v) =>
			new Vector2Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y));
	}
}
using UnityEngine;

namespace Vector3Extensions
{
	public static class Vector3Rounding
	{
		/// <summary>
		/// Returns a new Vector3 with the results of calling Mathf.Floor() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector3 Floor(this Vector3 v) => new Vector3(Mathf.Floor(v.x), Mathf.Floor(v.y), Mathf.Floor(v.z));
		
		/// <summary>
		/// Returns a new Vector3Int with the results of calling Mathf.FloorToInt() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector3Int FloorToInt(this Vector3 v) => new Vector3Int(Mathf.FloorToInt(v.x), Mathf.FloorToInt(v.y), Mathf.FloorToInt(v.z));
		
		/// <summary>
		/// Returns a new Vector3 with the results of calling Mathf.Ceil() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector3 Ceil(this Vector3 v) => new Vector3(Mathf.Ceil(v.x), Mathf.Ceil(v.y), Mathf.Ceil(v.z));
		
		/// <summary>
		/// Returns a new Vector3Int with the results of calling Mathf.CeilToInt() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector3Int CeilToInt(this Vector3 v) => new Vector3Int(Mathf.CeilToInt(v.x), Mathf.CeilToInt(v.y), Mathf.CeilToInt(v.z));
		
		/// <summary>
		/// Returns a new Vector3 with the results of calling Mathf.Round() on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector3 Round(this Vector3 v) => new Vector3(Mathf.Round(v.x), Mathf.Round(v.y), Mathf.Round(v.z));
		
		/// <summary>
		/// Returns a new Vector3Int with the results of calling Mathf.RoundToInt) on each of <see cref="v"/>'s components
		/// </summary>
		public static Vector3Int RoundToInt(this Vector3 v) => new Vector3Int(Mathf.RoundToInt(v.x), Mathf.RoundToInt(v.y), Mathf.RoundToInt(v.z));
	}
}
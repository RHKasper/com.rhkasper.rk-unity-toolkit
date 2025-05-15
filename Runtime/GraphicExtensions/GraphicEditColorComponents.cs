using RKUnityToolkit.ColorExtensions;
using UnityEngine.UI;

namespace RKUnityToolkit.GraphicExtensions
{
	public static class GraphicEditColorComponents
	{
		/// <summary>
		/// Sets the red component of a graphic's color.
		/// </summary>
		public static void SetRed(this Graphic g, float red) => g.color = g.color.WithRed(red);

		/// <summary>
		/// Sets the green component of a graphic's color.
		/// </summary>
		public static void SetGreen(this Graphic g, float green) => g.color = g.color.WithGreen(green);

		/// <summary>
		/// Sets the blue component of a graphic's color.
		/// </summary>
		public static void SetBlue(this Graphic g, float blue) => g.color = g.color.WithBlue(blue);

		/// <summary>
		/// Sets the alpha component of a graphic's color.
		/// </summary>
		public static void SetAlpha(this Graphic g, float alpha) => g.color = g.color.WithAlpha(alpha);
	}
}

using UnityEngine;

namespace ColorExtensions
{
	public static class ColorEditComponents
	{
		/// <summary>
		/// Returns a new color with the given <see cref="red"/> value and green, blue, and alpha (opacity) values from <see cref="c"/>
		/// </summary>
		public static Color WithRed(this Color c, float red) => new Color(red, c.g, c.b, c.a);
		
		/// <summary>
		/// Returns a new color with the given <see cref="green"/> value and red, blue, and alpha (opacity) values from <see cref="c"/>
		/// </summary>
		public static Color WithGreen(this Color c, float green) => new Color(c.r, green, c.b, c.a);
		
		/// <summary>
		/// Returns a new color with the given <see cref="blue"/> value and red, green, and alpha (opacity) values from <see cref="c"/>
		/// </summary>
		public static Color WithBlue(this Color c, float blue) => new Color(c.r, c.g, blue, c.a);
		
		/// <summary>
		/// Returns a new color with the given <see cref="alpha"/> value and red, green, and blue values from <see cref="c"/>
		/// </summary>
		public static Color WithAlpha(this Color c, float alpha) => new Color(c.r, c.g, c.b, alpha);
	}
}
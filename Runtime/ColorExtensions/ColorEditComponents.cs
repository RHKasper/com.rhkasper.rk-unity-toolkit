using System.Diagnostics.Contracts;
using UnityEngine;

namespace ColorExtensions
{
	/// <summary>
	/// Extensions for copying a color and replacing components on the copy
	/// </summary>
	public static class ColorEditComponents
	{
		/// <summary>
		/// Returns a new color with the given <see cref="red"/> value and green, blue, and alpha (opacity) values from <see cref="c"/>
		/// </summary>
		[Pure] public static Color WithRed(this Color c, float red) => new Color(red, c.g, c.b, c.a);
		
		/// <summary>
		/// Returns a new color with the given <see cref="green"/> value and red, blue, and alpha (opacity) values from <see cref="c"/>
		/// </summary>
		[Pure] public static Color WithGreen(this Color c, float green) => new Color(c.r, green, c.b, c.a);
		
		/// <summary>
		/// Returns a new color with the given <see cref="blue"/> value and red, green, and alpha (opacity) values from <see cref="c"/>
		/// </summary>
		[Pure] public static Color WithBlue(this Color c, float blue) => new Color(c.r, c.g, blue, c.a);
		
		/// <summary>
		/// Returns a new color with the given <see cref="alpha"/> value and red, green, and blue values from <see cref="c"/>
		/// </summary>
		[Pure] public static Color WithAlpha(this Color c, float alpha) => new Color(c.r, c.g, c.b, alpha);
	}
}
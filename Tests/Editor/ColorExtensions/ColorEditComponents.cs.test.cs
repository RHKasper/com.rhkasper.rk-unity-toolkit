using NUnit.Framework;
using RKUnityToolkit.ColorExtensions;
using UnityEngine;

namespace Tests.Editor.ColorExtensions
{
	public static class ColorEditComponentsTests
	{
		[Test] public static void WithRedTest()
		{
			Color c = new Color(1, 1, 1, 1);
			Assert.AreEqual(new Color(.35f,1,1,1), c.WithRed(.35f));
		}
		
		[Test] public static void WithGreenTest()
		{
			Color c = new Color(1,1,1,1);
			Assert.AreEqual(new Color(1,.75f,1,1), c.WithGreen(.75f));
		}
		
		[Test] public static void WithBlueTest()
		{
			Color c = new Color(1,1,1,1);
			Assert.AreEqual(new Color(1,1,.1f,1), c.WithBlue(.1f));
		} 
		
		[Test] public static void WithAlphaTest()
		{
			Color c = new Color(1,1,1,1);
			Assert.AreEqual(new Color(1,1,1,.25f), c.WithAlpha(.25f));
		}
	}
}
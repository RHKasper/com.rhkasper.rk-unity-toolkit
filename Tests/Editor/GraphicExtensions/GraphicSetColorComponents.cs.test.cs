using GraphicExtensions;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.UI;
using Object = UnityEngine.Object;

namespace Tests.Editor.GraphicExtensions
{
	public static class GraphicSetColorComponentsTests
	{
		[Test] public static void SetRedTest()
		{
			Graphic g = new GameObject().AddComponent<Image>();
			try
			{
				g.color = Color.white;
				g.SetRed(.35f);
				Assert.AreEqual(new Color(.35f, 1, 1, 1), g.color);
			}
			finally
			{
				Object.DestroyImmediate(g);
			}
		}
	
		[Test] public static void SetGreenTest()
		{
			Graphic g = new GameObject().AddComponent<Text>();
			try
			{
				g.color = Color.white;
				g.SetGreen(.17f);
				Assert.AreEqual(new Color(1, .17f, 1, 1), g.color);
			}
			finally
			{
				Object.DestroyImmediate(g);
			}
		}
	
		[Test] public static void SetBlueTest()
		{
			Graphic g = new GameObject().AddComponent<Text>();
			try
			{
				g.color = Color.white;
				g.SetBlue(.79f);
				Assert.AreEqual(new Color(1,1,.79f,1), g.color);
			}
			finally
			{
				Object.DestroyImmediate(g);
			}
		} 
	
		[Test] public static void SetAlphaTest()
		{
			Graphic g = new GameObject().AddComponent<Text>();
			try
			{
				g.color = Color.white;
				g.SetAlpha(0f);
				Assert.AreEqual(new Color(1,1,1,0), g.color);
			}
			finally
			{
				Object.DestroyImmediate(g);
			}
		}
	}
}
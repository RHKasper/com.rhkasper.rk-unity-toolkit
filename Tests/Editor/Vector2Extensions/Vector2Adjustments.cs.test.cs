using NUnit.Framework;
using UnityEngine;
using Vector2Extensions;

namespace Tests.Editor.Vector2Extensions
{
	public static class Vector2AdjustmentsTests
	{
		[Test] public static void AbsTest() => Assert.AreEqual(new Vector2(5,6.5f), new Vector2(-5,-6.5f).Abs());
		[Test] public static void ClampTest() => Assert.AreEqual(new Vector2(4,-1), new Vector2(5,-6).Clamp(new Vector2(2, -1), new Vector2(4, 6)));
		[Test] public static void DigitizeTest() => Assert.AreEqual(new Vector2(1, 0), new Vector2(5, 0).Digitize());
		[Test] public static void MaxTest() => Assert.AreEqual(new Vector2(5,8), new Vector2(5,6).Max(new Vector2(3, 8)));
		[Test] public static void MinTest() => Assert.AreEqual(new Vector2(3,6), new Vector2(5,6).Min(new Vector2(3, 8)));
		[Test] public static void MaxComponentTest() => Assert.AreEqual(6f, new Vector2(5, 6).MaxComponent());
		[Test] public static void MinComponentTest() => Assert.AreEqual(5f, new Vector2(5, 6).MinComponent());
		[Test] public static void SignTestNeg() => Assert.AreEqual(new Vector2(0, -1), new Vector2(0, -2).Sign());
		[Test] public static void SignTestPos() => Assert.AreEqual(new Vector2(1, 0), new Vector2(5, 0).Sign());
	}
}
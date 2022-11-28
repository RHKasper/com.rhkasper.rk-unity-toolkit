using NUnit.Framework;
using UnityEngine;
using Vector2IntExtensions;

namespace Tests.Editor.Vector2IntExtensions
{
	public static class Vector2IntAdjustmentsTests
	{
		[Test] public static void AbsTest() => Assert.AreEqual(new Vector2Int(5,6), new Vector2Int(-5,-6).Abs());
		[Test] public static void DigitizeTest() => Assert.AreEqual(new Vector2Int(1, 0), new Vector2Int(5, 0).Digitize());
		[Test] public static void MaxTest() => Assert.AreEqual(new Vector2Int(5,8), new Vector2Int(5,6).Max(new Vector2Int(3, 8)));
		[Test] public static void MinTest() => Assert.AreEqual(new Vector2Int(3,6), new Vector2Int(5,6).Min(new Vector2Int(3, 8)));
		[Test] public static void MaxComponentTest() => Assert.AreEqual(6f, new Vector2Int(5, 6).MaxComponent());
		[Test] public static void MinComponentTest() => Assert.AreEqual(5f, new Vector2Int(5, 6).MinComponent());
		[Test] public static void SignTestNeg() => Assert.AreEqual(new Vector2Int(0, -1), new Vector2Int(0, -2).Sign());
		[Test] public static void SignTestPos() => Assert.AreEqual(new Vector2Int(1, 0), new Vector2Int(5, 0).Sign());
	}
}
using NUnit.Framework;
using UnityEngine;
using Vector3Extensions;

namespace Tests.Editor.Vector3Extensions
{
	public static class Vector3AdjustmentsTests
	{
		[Test] public static void AbsTest() => Assert.AreEqual(new Vector3(5,6.5f, 1.5f), new Vector3(-5,-6.5f, 1.5f).Abs());
		[Test] public static void ClampTest() => Assert.AreEqual(new Vector3(4,-1, 7), new Vector3(5,-6, 7).Clamp(new Vector3(2, -1, 2), new Vector3(4, 6, 10)));
		[Test] public static void DigitizeTest() => Assert.AreEqual(new Vector3(1, 0, 1), new Vector3(5, 0, -1).Digitize());
		[Test] public static void MaxTest() => Assert.AreEqual(new Vector3(5,8, 20), new Vector3(5,6, 20).Max(new Vector3(3, 8, -50)));
		[Test] public static void MinTest() => Assert.AreEqual(new Vector3(3,6, -50), new Vector3(5,6, 20).Min(new Vector3(3, 8, -50)));
		[Test] public static void MaxComponentTest() => Assert.AreEqual(12f, new Vector3(5, 6, 12).MaxComponent());
		[Test] public static void MinComponentTest() => Assert.AreEqual(5f, new Vector3(5, 6, 12).MinComponent());
		[Test] public static void SignTest() => Assert.AreEqual(new Vector3(0, -1, 1), new Vector3(0, -2, 3).Sign());
	}
}
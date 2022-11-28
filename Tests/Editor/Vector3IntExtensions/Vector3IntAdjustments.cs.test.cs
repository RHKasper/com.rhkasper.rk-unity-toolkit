using NUnit.Framework;
using UnityEngine;
using Vector3IntExtensions;

namespace Tests.Editor.Vector3IntExtensions
{
	public static class Vector3IntAdjustmentsTests
	{
		[Test] public static void AbsTest() => Assert.AreEqual(new Vector3Int(5,65, 15), new Vector3Int(-5,-65, 15).Abs());
		[Test] public static void DigitizeTest() => Assert.AreEqual(new Vector3Int(1, 0, 1), new Vector3Int(5, 0, -1).Digitize());
		[Test] public static void MaxTest() => Assert.AreEqual(new Vector3Int(5,8, 20), new Vector3Int(5,6, 20).Max(new Vector3Int(3, 8, -50)));
		[Test] public static void MinTest() => Assert.AreEqual(new Vector3Int(3,6, -50), new Vector3Int(5,6, 20).Min(new Vector3Int(3, 8, -50)));
		[Test] public static void MaxComponentTest() => Assert.AreEqual(12, new Vector3Int(5, 6, 12).MaxComponent());
		[Test] public static void MinComponentTest() => Assert.AreEqual(5, new Vector3Int(5, 6, 12).MinComponent());
		[Test] public static void SignTest() => Assert.AreEqual(new Vector3Int(0, -1, 1), new Vector3Int(0, -2, 3).Sign());
	}
}
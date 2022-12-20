using NUnit.Framework;
using UnityEngine;
using Vector2IntExtensions;

namespace Tests.Editor.Vector2IntExtensions
{
	public static class Vector2IntMultiplyTests
	{
		[Test]
		public static void TestVector2Int()
		{
			Assert.AreEqual(new Vector2Int(6, 21), new Vector2Int(2, 3).Multiply(new Vector2Int(3, 7)));
		}
		
		[Test]
		public static void TestVector2()
		{
			Assert.AreEqual(new Vector2(2.5f, 7.5f), new Vector2Int(2, 15).Multiply(new Vector2(1.25f, .5f)));
		}
	}
}
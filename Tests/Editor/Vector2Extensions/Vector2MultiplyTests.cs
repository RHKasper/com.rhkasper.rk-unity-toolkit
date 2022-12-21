using NUnit.Framework;
using UnityEngine;
using Vector2Extensions;

namespace Tests.Editor.Vector2Extensions
{
	public static class Vector2MultiplyTests
	{
		[Test]
		public static void TestVector2()
		{
			Assert.AreEqual(new Vector2(2.5f, 7.5f), new Vector2(1.25f, .5f).Multiply(new Vector2Int(2, 15)));
		}
		
		[Test]
		public static void TestVector2Int()
		{
			Assert.AreEqual(new Vector2(.625f, .15f), new Vector2(1.25f, .45f).Multiply(new Vector2(.5f, 1/3f)));
		}
	}
}
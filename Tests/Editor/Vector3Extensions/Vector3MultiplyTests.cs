using NUnit.Framework;
using UnityEngine;
using Vector3Extensions;

namespace Tests.Editor.Vector3Extensions
{
	public static class Vector3MultiplyTests
	{
		[Test]
		public static void TestVector3()
		{
			Assert.AreEqual(new Vector3(2.5f, 7.5f, 9f), new Vector3(1.25f, .5f, 3f).Multiply(new Vector3Int(2, 15, 3)));
		}
		
		[Test]
		public static void TestVector3Int()
		{
			Assert.AreEqual(new Vector3(.625f, .15f, 3f), new Vector3(1.25f, .45f, .3f).Multiply(new Vector3(.5f, 1/3f, 10)));
		}
	}
}
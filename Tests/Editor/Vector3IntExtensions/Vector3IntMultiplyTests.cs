using NUnit.Framework;
using UnityEngine;
using Vector3IntExtensions;

namespace Tests.Editor.Vector3IntExtensions
{
	public static class Vector3IntMultiplyTests
	{
		[Test]
		public static void TestVector3Int()
		{
			Assert.AreEqual(new Vector3Int(6, 21, 44), new Vector3Int(2, 3, 11).Multiply(new Vector3Int(3, 7, 4)));
		}
		
		[Test]
		public static void TestVector3()
		{
			Assert.AreEqual(new Vector3(2.5f, 7.5f, 23f), new Vector3Int(2, 15, 2).Multiply(new Vector3(1.25f, .5f, 11.5f)));
		}
	}
}
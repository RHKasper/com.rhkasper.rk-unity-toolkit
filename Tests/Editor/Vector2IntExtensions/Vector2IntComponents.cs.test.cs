using NUnit.Framework;
using UnityEngine;
using Vector2IntExtensions;

namespace Tests.Editor.Vector2IntExtensions
{
	public static class Vector2IntComponentsTests
	{
		[Test]
		public static void Test()
		{
			Vector2Int v = new Vector2Int(1, 2);
			
			Assert.AreEqual(new Vector2Int(0,1), v.OX());
			Assert.AreEqual(new Vector2Int(0,2), v.OY());
			Assert.AreEqual(new Vector2Int(1,0), v.XO());
			Assert.AreEqual(new Vector2Int(1,1), v.XX());
			Assert.AreEqual(new Vector2Int(2,0), v.YO());
			Assert.AreEqual(new Vector2Int(2,1), v.YX());
			Assert.AreEqual(new Vector2Int(2,2), v.YY());
		}
	}
}
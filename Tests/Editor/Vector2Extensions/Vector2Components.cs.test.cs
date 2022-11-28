using NUnit.Framework;
using UnityEngine;
using Vector2Extensions;

namespace Tests.Editor.Vector2Extensions
{
	public static class Vector2ComponentsTests
	{
		[Test]
		public static void Test()
		{
			Vector2 v = new Vector2(1, 2);
			
			Assert.AreEqual(new Vector2(0,1), v.OX());
			Assert.AreEqual(new Vector2(0,2), v.OY());
			Assert.AreEqual(new Vector2(1,0), v.XO());
			Assert.AreEqual(new Vector2(1,1), v.XX());
			Assert.AreEqual(new Vector2(2,0), v.YO());
			Assert.AreEqual(new Vector2(2,1), v.YX());
			Assert.AreEqual(new Vector2(2,2), v.YY());
		}
	}
}
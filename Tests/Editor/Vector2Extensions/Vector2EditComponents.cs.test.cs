using NUnit.Framework;
using UnityEngine;
using Vector2Extensions;

namespace Tests.Editor.Vector2Extensions
{
	public static class Vector2EditComponentsTests
	{
		[Test]
		public static void Test()
		{
			Vector2 v = new Vector2(4, 5);
			
			Assert.AreEqual(new Vector2(8,5), v.WithX(8));
			Assert.AreEqual(new Vector2(4,8), v.WithY(8)); 
			
			Assert.AreEqual(new Vector2(-4,5), v.WithNegativeX());
			Assert.AreEqual(new Vector2(4,-5), v.WithNegativeY()); 
		}
	}
}
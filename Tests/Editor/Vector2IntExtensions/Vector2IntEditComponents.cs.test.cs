using NUnit.Framework;
using UnityEngine;
using Vector2IntExtensions;

namespace Tests.Editor.Vector2IntExtensions
{
	public static class Vector2IntEditComponentsTests
	{
		[Test]
		public static void Test()
		{
			Vector2Int v = new Vector2Int(4, 5);
			
			Assert.AreEqual(new Vector2Int(8,5), v.WithX(8));
			Assert.AreEqual(new Vector2Int(4,8), v.WithY(8));
			
			Assert.AreEqual(new Vector2Int(-4,5), v.WithNegativeX());
			Assert.AreEqual(new Vector2Int(4,-5), v.WithNegativeY()); 
		}
	}
}
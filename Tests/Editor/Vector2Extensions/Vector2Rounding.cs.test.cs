using NUnit.Framework;
using UnityEngine;
using Vector2Extensions;

namespace Tests.Editor.Vector2Extensions
{
	public static class Vector2RoundingTests
	{
		[Test]
		public static void Test()
		{
			Vector2 v = new Vector2(5.8f, 2.4f);
			
			Assert.AreEqual(new Vector2(5, 2), v.Floor());
			Assert.AreEqual(new Vector2Int(5, 2), v.FloorToInt());

			Assert.AreEqual(new Vector2(6, 3), v.Ceil());
			Assert.AreEqual(new Vector2Int(6, 3), v.CeilToInt());
			
			Assert.AreEqual(new Vector2(6, 2), v.Round());
			Assert.AreEqual(new Vector2Int(6, 2), v.RoundToInt());
		}
	}
}
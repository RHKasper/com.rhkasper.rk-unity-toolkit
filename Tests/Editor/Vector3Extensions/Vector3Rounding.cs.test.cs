using NUnit.Framework;
using UnityEngine;
using Vector3Extensions;

namespace Tests.Editor.Vector3Extensions
{
	public static class Vector3RoundingTests
	{
		[Test]
		public static void Test()
		{
			Vector3 v = new Vector3(5.8f, 2.4f, 4.25f);
			
			Assert.AreEqual(new Vector3(5, 2, 4), v.Floor());
			Assert.AreEqual(new Vector3Int(5, 2, 4), v.FloorToInt());

			Assert.AreEqual(new Vector3(6, 3, 5), v.Ceil());
			Assert.AreEqual(new Vector3Int(6, 3, 5), v.CeilToInt());
			
			Assert.AreEqual(new Vector3(6, 2, 4), v.Round());
			Assert.AreEqual(new Vector3Int(6, 2, 4), v.RoundToInt());
		}
	}
}
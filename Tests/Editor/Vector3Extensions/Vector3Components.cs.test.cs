using NUnit.Framework;
using UnityEngine;
using Vector3Extensions;

namespace Tests.Editor.Vector3Extensions
{
	public static class Vector3ComponentsTests
	{
		[Test]
		public static void Test()
		{
			Vector3 v = new Vector3(2, 3, 4);
			
			Assert.AreEqual(new Vector3(0, 0, 2), v.OOX());
			Assert.AreEqual(new Vector3(0, 0, 3), v.OOY());
			Assert.AreEqual(new Vector3(0, 0, 4), v.OOZ());
			Assert.AreEqual(new Vector3(0, 2, 0), v.OXO());
			Assert.AreEqual(new Vector3(0, 2, 2), v.OXX());
			Assert.AreEqual(new Vector3(0, 2, 3), v.OXY());
			Assert.AreEqual(new Vector3(0, 2, 4), v.OXZ());
			Assert.AreEqual(new Vector3(0, 3, 0), v.OYO());
			Assert.AreEqual(new Vector3(0, 3, 2), v.OYX());
			Assert.AreEqual(new Vector3(0, 3, 3), v.OYY());
			Assert.AreEqual(new Vector3(0, 3, 4), v.OYZ());
			Assert.AreEqual(new Vector3(0, 4, 0), v.OZO());
			Assert.AreEqual(new Vector3(0, 4, 2), v.OZX());
			Assert.AreEqual(new Vector3(0, 4, 3), v.OZY());
			Assert.AreEqual(new Vector3(0, 4, 4), v.OZZ());
			Assert.AreEqual(new Vector3(2, 0, 0), v.XOO());
			Assert.AreEqual(new Vector3(2, 0, 2), v.XOX());
			Assert.AreEqual(new Vector3(2, 0, 3), v.XOY());
			Assert.AreEqual(new Vector3(2, 0, 4), v.XOZ());
			Assert.AreEqual(new Vector3(2, 2, 0), v.XXO());
			Assert.AreEqual(new Vector3(2, 2, 2), v.XXX());
			Assert.AreEqual(new Vector3(2, 2, 3), v.XXY());
			Assert.AreEqual(new Vector3(2, 2, 4), v.XXZ());
			Assert.AreEqual(new Vector3(2, 3, 0), v.XYO());
			Assert.AreEqual(new Vector3(2, 3, 2), v.XYX());
			Assert.AreEqual(new Vector3(2, 3, 3), v.XYY());
			Assert.AreEqual(new Vector3(2, 4, 0), v.XZO());
			Assert.AreEqual(new Vector3(2, 4, 2), v.XZX());
			Assert.AreEqual(new Vector3(2, 4, 3), v.XZY());
			Assert.AreEqual(new Vector3(2, 4, 4), v.XZZ());
			Assert.AreEqual(new Vector3(3, 0, 0), v.YOO());
			Assert.AreEqual(new Vector3(3, 0, 2), v.YOX());
			Assert.AreEqual(new Vector3(3, 0, 3), v.YOY());
			Assert.AreEqual(new Vector3(3, 0, 4), v.YOZ());
			Assert.AreEqual(new Vector3(3, 2, 0), v.YXO());
			Assert.AreEqual(new Vector3(3, 2, 2), v.YXX());
			Assert.AreEqual(new Vector3(3, 2, 3), v.YXY());
			Assert.AreEqual(new Vector3(3, 2, 4), v.YXZ());
			Assert.AreEqual(new Vector3(3, 3, 0), v.YYO());
			Assert.AreEqual(new Vector3(3, 3, 2), v.YYX());
			Assert.AreEqual(new Vector3(3, 3, 3), v.YYY());
			Assert.AreEqual(new Vector3(3, 3, 4), v.YYZ());
			Assert.AreEqual(new Vector3(3, 4, 0), v.YZO());
			Assert.AreEqual(new Vector3(3, 4, 2), v.YZX());
			Assert.AreEqual(new Vector3(3, 4, 3), v.YZY());
			Assert.AreEqual(new Vector3(3, 4, 4), v.YZZ());
			Assert.AreEqual(new Vector3(4, 0, 0), v.ZOO());
			Assert.AreEqual(new Vector3(4, 0, 2), v.ZOX());
			Assert.AreEqual(new Vector3(4, 0, 3), v.ZOY());
			Assert.AreEqual(new Vector3(4, 0, 4), v.ZOZ());
			Assert.AreEqual(new Vector3(4, 2, 0), v.ZXO());
			Assert.AreEqual(new Vector3(4, 2, 2), v.ZXX());
			Assert.AreEqual(new Vector3(4, 2, 3), v.ZXY());
			Assert.AreEqual(new Vector3(4, 2, 4), v.ZXZ());
			Assert.AreEqual(new Vector3(4, 3, 0), v.ZYO());
			Assert.AreEqual(new Vector3(4, 3, 2), v.ZYX());
			Assert.AreEqual(new Vector3(4, 3, 3), v.ZYY());
			Assert.AreEqual(new Vector3(4, 3, 4), v.ZYZ());
			Assert.AreEqual(new Vector3(4, 4, 0), v.ZZO());
			Assert.AreEqual(new Vector3(4, 4, 2), v.ZZX());
			Assert.AreEqual(new Vector3(4, 4, 3), v.ZZY());
			Assert.AreEqual(new Vector3(4, 4, 4), v.ZZZ());
		}
	}
}
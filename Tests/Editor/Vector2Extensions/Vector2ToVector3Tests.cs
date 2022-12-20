using NUnit.Framework;
using UnityEngine;
using Vector2Extensions;
using Vector3Extensions;

namespace Tests.Editor.Vector2Extensions
{
	public static class Vector2ToVector3Tests
	{
		[Test]
		public static void Test()
		{
			Vector2 v = new Vector2(2, 3);
			
			Assert.AreEqual(new Vector3(0, 0, 2), v.OOX());
			Assert.AreEqual(new Vector3(0, 0, 3), v.OOY());
			Assert.AreEqual(new Vector3(0, 2, 0), v.OXO());
			Assert.AreEqual(new Vector3(0, 2, 2), v.OXX());
			Assert.AreEqual(new Vector3(0, 2, 3), v.OXY());
			Assert.AreEqual(new Vector3(0, 3, 0), v.OYO());
			Assert.AreEqual(new Vector3(0, 3, 2), v.OYX());
			Assert.AreEqual(new Vector3(0, 3, 3), v.OYY());
			Assert.AreEqual(new Vector3(2, 0, 0), v.XOO());
			Assert.AreEqual(new Vector3(2, 0, 2), v.XOX());
			Assert.AreEqual(new Vector3(2, 0, 3), v.XOY());
			Assert.AreEqual(new Vector3(2, 2, 0), v.XXO());
			Assert.AreEqual(new Vector3(2, 2, 2), v.XXX());
			Assert.AreEqual(new Vector3(2, 2, 3), v.XXY());
			Assert.AreEqual(new Vector3(2, 3, 0), v.XYO());
			Assert.AreEqual(new Vector3(2, 3, 2), v.XYX());
			Assert.AreEqual(new Vector3(2, 3, 3), v.XYY());
			Assert.AreEqual(new Vector3(3, 0, 0), v.YOO());
			Assert.AreEqual(new Vector3(3, 0, 2), v.YOX());
			Assert.AreEqual(new Vector3(3, 0, 3), v.YOY());
			Assert.AreEqual(new Vector3(3, 2, 0), v.YXO());
			Assert.AreEqual(new Vector3(3, 2, 2), v.YXX());
			Assert.AreEqual(new Vector3(3, 2, 3), v.YXY());
			Assert.AreEqual(new Vector3(3, 3, 0), v.YYO());
			Assert.AreEqual(new Vector3(3, 3, 2), v.YYX());
			Assert.AreEqual(new Vector3(3, 3, 3), v.YYY());
		}
	}
}
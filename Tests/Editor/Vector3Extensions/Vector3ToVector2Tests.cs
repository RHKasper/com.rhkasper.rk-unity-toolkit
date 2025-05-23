﻿using NUnit.Framework;
using UnityEngine;
using Vector3Extensions;

namespace Tests.Editor.Vector3Extensions
{
	/// <summary>
	/// This class includes a bunch of extension methods for Vector3 that allow you to convert to a Vector2 with components arranged however you like
	/// </summary>
	public static class Vector3ToVector2Tests
	{
		private static Vector3 v = new Vector3(2,3,4); 
		
		[Test]public static void OXTest() => Assert.AreEqual(new Vector2(0,2), v.OX());
		[Test]public static void OYTest() => Assert.AreEqual(new Vector2(0,3), v.OY());
		[Test]public static void OZTest() => Assert.AreEqual(new Vector2(0,4), v.OZ());
		[Test]public static void XOTest() => Assert.AreEqual(new Vector2(2,0), v.XO());
		[Test]public static void XXTest() => Assert.AreEqual(new Vector2(2,2), v.XX());
		[Test]public static void XYTest() => Assert.AreEqual(new Vector2(2,3), v.XY());
		[Test]public static void XZTest() => Assert.AreEqual(new Vector2(2,4), v.XZ());
		[Test]public static void YOTest() => Assert.AreEqual(new Vector2(3,0), v.YO());
		[Test]public static void YXTest() => Assert.AreEqual(new Vector2(3,2), v.YX());
		[Test]public static void YYTest() => Assert.AreEqual(new Vector2(3,3), v.YY());
		[Test]public static void YZTest() => Assert.AreEqual(new Vector2(3,4), v.YZ());
		[Test]public static void ZOTest() => Assert.AreEqual(new Vector2(4,0), v.ZO());
		[Test]public static void ZXTest() => Assert.AreEqual(new Vector2(4,2), v.ZX());
		[Test]public static void ZYTest() => Assert.AreEqual(new Vector2(4,3), v.ZY());
		[Test]public static void ZZTest() => Assert.AreEqual(new Vector2(4,4), v.ZZ());
	}
}
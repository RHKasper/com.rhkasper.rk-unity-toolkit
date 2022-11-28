using NUnit.Framework;
using UnityEngine;
using Vector3Extensions;

namespace Tests.Editor.Vector3Extensions
{
	public static class Vector3EditComponentsTests
	{
		[Test]
		public static void Test()
		{
			Vector3 v = new Vector3(4, 5, 6);
			
			Assert.AreEqual(new Vector3(8,5, 6), v.WithX(8));
			Assert.AreEqual(new Vector3(4,8, 6), v.WithY(8)); 
			Assert.AreEqual(new Vector3(4,5, 8), v.WithZ(8)); 
			
			Assert.AreEqual(new Vector3(8,9, 6), v.WithXY(8, 9));
			Assert.AreEqual(new Vector3(8,5, 9), v.WithXZ(8, 9)); 
			Assert.AreEqual(new Vector3(4,8, 9), v.WithYZ(8, 9)); 
			
			Assert.AreEqual(new Vector3(-4,5, 6), v.WithNegativeX());
			Assert.AreEqual(new Vector3(4,-5, 6), v.WithNegativeY()); 
			Assert.AreEqual(new Vector3(4,5, -6), v.WithNegativeZ()); 
		}
	}
}
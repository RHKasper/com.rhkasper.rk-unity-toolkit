using System.Collections.Generic;
using LINQExtensions;
using NUnit.Framework;
using UnityEngine;

namespace Tests.Editor.LINQExtensions
{
	public static class LinqMostLeastTests
	{
		[Test]
		public static void Test()
		{
			List<int> intList = new List<int> { 5, 2, 8, -19, 20 };
			List<Vector3> v3List = new List<Vector3> { new Vector3(5, 9, -9), new Vector3(8, 2, 20), new Vector3(1, 1, 1), new Vector3(1, 1, 1), new Vector3(-4, -19, 6), };
			
			Assert.AreEqual(intList[4], intList.Most(i => i));
			Assert.AreEqual(v3List[1], v3List.Most(v => v.z));
			Assert.AreEqual(v3List[4], v3List.Most(v => v.x * v.y));

			Assert.AreEqual(intList[3], intList.Least(i => i));
			Assert.AreEqual(v3List[0], v3List.Least(v => v.z));
			Assert.AreEqual(v3List[2], v3List.Least(v => v.x * v.y));
		}
	}
}
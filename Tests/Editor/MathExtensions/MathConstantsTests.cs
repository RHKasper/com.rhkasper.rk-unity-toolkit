using System;
using MathExtensions;
using NUnit.Framework;
using UnityEngine;

namespace Tests.Editor.MathExtensions
{
	public static class MathConstantsTests
	{
		[Test]
		public static void PiTest() => Assert.AreEqual(Mathf.PI, MathConstants.Pi);
		
		[Test]
		public static void ETest() => Assert.AreEqual((float)Math.E, MathConstants.E);
		
		[Test]
		public static void Sqrt2Test() => Assert.AreEqual(Mathf.Sqrt(2), MathConstants.Sqrt2);
		
		[Test]
		public static void Sqrt3Test() => Assert.AreEqual(Mathf.Sqrt(3), MathConstants.Sqrt3);
		
		[Test]
		public static void Sqrt2Over2Test() => Assert.AreEqual(Mathf.Sqrt(2)/2, MathConstants.Sqrt2Over2);
		
		[Test]
		public static void Sqrt3Over2Test() => Assert.AreEqual(Mathf.Sqrt(3)/2, MathConstants.Sqrt3Over2);
	}
}
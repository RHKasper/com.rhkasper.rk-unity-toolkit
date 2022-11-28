using System.Reflection;
using Easing;
using NUnit.Framework;

namespace Tests.Editor.Easing
{
	public static class EasingFunctionsTests
	{
		[Test]
		public static void EasingEndpointsTest()
		{
			foreach (MethodInfo method in typeof(EasingFunctions).GetMethods(BindingFlags.Public | BindingFlags.Static))
			{
				var shouldBeZero = method.Invoke(null, new object[]{0});
				var shouldBeOne = method.Invoke(null, new object[]{1});
			
				Assert.AreEqual(0, shouldBeZero, $"Calling {method.Name} with 0 as an argument does not return 0");
				Assert.AreEqual(1, shouldBeOne, $"Calling {method.Name} with 1 as an argument does not return 1");
			}
		}
		
		[Test]
		public static void EasingUnderTest()
		{
			foreach (MethodInfo method in typeof(EasingFunctions).GetMethods(BindingFlags.Public | BindingFlags.Static))
			{
				var shouldBeZero = method.Invoke(null, new object[]{-124});
				Assert.AreEqual(0, shouldBeZero, $"Calling {method.Name} with a number less than 0 as an argument does not return 0");
			}
		}
		
		[Test]
		public static void EasingOverTest()
		{
			foreach (MethodInfo method in typeof(EasingFunctions).GetMethods(BindingFlags.Public | BindingFlags.Static))
			{
				var shouldBeOne = method.Invoke(null, new object[]{125});
				Assert.AreEqual(1, shouldBeOne, $"Calling {method.Name} with a number greater than 1 as an argument does not return 1");

			}
		}
	}
}
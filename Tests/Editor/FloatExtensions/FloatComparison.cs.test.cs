using FloatExtensions;
using NUnit.Framework;

namespace Tests.Editor.FloatExtensions
{
	public static class FloatComparisonTests
	{
		[Test]
		public static void Test()
		{
			Assert.AreEqual(true, 1.750001f.RoughlyEquals(1.75f));
		}
	}
}
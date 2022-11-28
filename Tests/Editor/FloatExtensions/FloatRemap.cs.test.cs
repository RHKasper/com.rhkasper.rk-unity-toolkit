using FloatExtensions;
using NUnit.Framework;

namespace Tests.Editor.FloatExtensions
{
	public static class FloatRemapTests
	{
		[Test]
		public static void RemapTest()
		{
			Assert.AreEqual(4, 5f.Remap(0, 10, 1, 7));
			Assert.AreEqual(1, (-5f).Remap(0, 10, 1, 7));
			Assert.AreEqual(7, 50f.Remap(0, 10, 1, 7));
		}
	}
}
using System.Diagnostics.Contracts;
using Easing;
using UnityEngine;

namespace FloatExtensions
{
	public static class FloatRemap
	{
		[Pure] public static float Remap(this float f, float inMin, float inMax, float outMin, float outMax, EasingType type = EasingType.Linear)
		{
			float inPortion = Mathf.Clamp01((f - inMin) / (inMax - inMin));
			return EasingUtil.Ease(outMin, outMax, inPortion, type);
		}
	}
}
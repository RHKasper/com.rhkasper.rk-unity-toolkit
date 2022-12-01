using System;
using System.Diagnostics.Contracts;

namespace Easing
{
	/// <summary>
	/// This class provides a generic entry point for the methods in <see cref="EasingFunctions"/>.
	/// </summary>
	public static class EasingUtil
	{
		[Pure] public static float Ease(float start, float end, float portion, EasingType type = EasingType.Linear)
		{
			return start + (end - start) * CalculateEasedValue(portion, type);
		}

		[Pure] private static float CalculateEasedValue(float initialValue, EasingType easingType)
		{
			return easingType switch
			{
				EasingType.Linear => EasingFunctions.Linear(initialValue),
				
				EasingType.EaseInSine => EasingFunctions.EaseInSine(initialValue),
				EasingType.EaseOutSine => EasingFunctions.EaseOutSine(initialValue),
				EasingType.EaseInOutSine => EasingFunctions.EaseInOutSine(initialValue),
				
				EasingType.EaseInQuad => EasingFunctions.EaseInQuad(initialValue),
				EasingType.EaseOutQuad => EasingFunctions.EaseOutQuad(initialValue),
				EasingType.EaseInOutQuad => EasingFunctions.EaseInOutQuad(initialValue),
				
				EasingType.EaseInCubic => EasingFunctions.EaseInCubic(initialValue),
				EasingType.EaseOutCubic => EasingFunctions.EaseOutCubic(initialValue),
				EasingType.EaseInOutCubic => EasingFunctions.EaseInOutCubic(initialValue),
				
				EasingType.EaseInQuart => EasingFunctions.EaseInQuart(initialValue),
				EasingType.EaseOutQuart => EasingFunctions.EaseOutQuart(initialValue),
				EasingType.EaseInOutQuart => EasingFunctions.EaseInOutQuart(initialValue),
				
				EasingType.EaseInQuint => EasingFunctions.EaseInQuint(initialValue),
				EasingType.EaseOutQuint => EasingFunctions.EaseOutQuint(initialValue),
				EasingType.EaseInOutQuint => EasingFunctions.EaseInOutQuint(initialValue),
				
				EasingType.EaseInExpo => EasingFunctions.EaseInExpo(initialValue),
				EasingType.EaseOutExpo => EasingFunctions.EaseOutExpo(initialValue),
				EasingType.EaseInOutExpo => EasingFunctions.EaseInOutExpo(initialValue),
				
				EasingType.EaseInCirc => EasingFunctions.EaseInCirc(initialValue),
				EasingType.EaseOutCirc => EasingFunctions.EaseOutCirc(initialValue),
				EasingType.EaseInOutCirc => EasingFunctions.EaseInOutCirc(initialValue),
				
				EasingType.EaseInBack => EasingFunctions.EaseInBack(initialValue),
				EasingType.EaseOutBack => EasingFunctions.EaseOutBack(initialValue),
				EasingType.EaseInOutBack => EasingFunctions.EaseInOutBack(initialValue),
				
				EasingType.EaseInElastic => EasingFunctions.EaseInElastic(initialValue),
				EasingType.EaseOutElastic => EasingFunctions.EaseOutElastic(initialValue),
				EasingType.EaseInOutElastic => EasingFunctions.EaseInOutElastic(initialValue),
				
				EasingType.EaseInBounce => EasingFunctions.EaseInBounce(initialValue),
				EasingType.EaseOutBounce => EasingFunctions.EaseOutBounce(initialValue),
				EasingType.EaseInOutBounce => EasingFunctions.EaseInOutBounce(initialValue),
				
				_ => throw new ArgumentOutOfRangeException(nameof(easingType), easingType, null)
			};
		}
	}
}
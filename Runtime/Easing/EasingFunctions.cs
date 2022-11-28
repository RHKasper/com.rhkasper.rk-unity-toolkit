using UnityEngine;

namespace Easing
{
	/// <summary>
	/// This class float implementations of all the easing functions described at https://easings.net/
	/// </summary>
	public static class EasingFunctions
	{
		
		public static float Linear(float x)
		{
			x = Mathf.Clamp01(x);
			return x;
		}


		public static float EaseInSine(float x)
		{
			x = Mathf.Clamp01(x);
			return 1 - Mathf.Cos(x * Mathf.PI / 2);
		}

		public static float EaseOutSine(float x)
		{
			x = Mathf.Clamp01(x);
			return Mathf.Sin(x * Mathf.PI / 2);
		}

		public static float EaseInOutSine(float x)
		{
			x = Mathf.Clamp01(x);
			return -(Mathf.Cos(Mathf.PI * x) - 1) / 2;
		}


		public static float EaseInQuad(float x)
		{
			x = Mathf.Clamp01(x);
			return x * x;
		}

		public static float EaseOutQuad(float x)
		{
			x = Mathf.Clamp01(x);
			return 1 - (1 - x) * (1 - x);
		}

		public static float EaseInOutQuad(float x)
		{
			x = Mathf.Clamp01(x);
			return x < 0.5 ? 2 * x * x : 1 - Mathf.Pow(-2 * x + 2, 2) / 2;
		}


		public static float EaseInCubic(float x)
		{
			x = Mathf.Clamp01(x);
			return x * x * x;
		}

		public static float EaseOutCubic(float x)
		{
			x = Mathf.Clamp01(x);
			return 1 - Mathf.Pow(1 - x, 3);
		}

		public static float EaseInOutCubic(float x)
		{
			x = Mathf.Clamp01(x);
			return x < 0.5 ? 4 * x * x * x : 1 - Mathf.Pow(-2 * x + 2, 3) / 2;
		}


		public static float EaseInQuart(float x)
		{
			x = Mathf.Clamp01(x);
			return x * x * x * x;
		}

		public static float EaseOutQuart(float x)
		{
			x = Mathf.Clamp01(x);
			return 1 - Mathf.Pow(1 - x, 4);
		}

		public static float EaseInOutQuart(float x)
		{
			x = Mathf.Clamp01(x);
			return x < 0.5 ? 8 * x * x * x * x : 1 - Mathf.Pow(-2 * x + 2, 4) / 2;
		}


		public static float EaseInQuint(float x)
		{
			x = Mathf.Clamp01(x);
			return x * x * x * x * x;
		}

		public static float EaseOutQuint(float x)
		{
			x = Mathf.Clamp01(x);
			return 1 - Mathf.Pow(1 - x, 5);
		}

		public static float EaseInOutQuint(float x)
		{
			x = Mathf.Clamp01(x);
			return x < 0.5 ? 16 * x * x * x * x * x : 1 - Mathf.Pow(-2 * x + 2, 5) / 2;
		}


		public static float EaseInExpo(float x)
		{
			x = Mathf.Clamp01(x);
			return x <= 0 ? 0 : Mathf.Pow(2, 10 * x - 10);
		}

		public static float EaseOutExpo(float x)
		{
			x = Mathf.Clamp01(x);
			return x >= 1 ? 1 : 1 - Mathf.Pow(2, -10 * x);
		}

		public static float EaseInOutExpo(float x)
		{
			x = Mathf.Clamp01(x);
			return x <= 0 ? 0 :
				x >= 1 ? 1 :
				x < 0.5 ? Mathf.Pow(2, 20 * x - 10) / 2 : (2 - Mathf.Pow(2, -20 * x + 10)) / 2;
		}


		public static float EaseInCirc(float x)
		{
			x = Mathf.Clamp01(x);
			return 1 - Mathf.Sqrt(1 - Mathf.Pow(x, 2));
		}

		public static float EaseOutCirc(float x)
		{
			x = Mathf.Clamp01(x);
			return Mathf.Sqrt(1 - Mathf.Pow(x - 1, 2));
		}

		public static float EaseInOutCirc(float x)
		{
			x = Mathf.Clamp01(x);
			return x < 0.5f
				? (1 - Mathf.Sqrt(1 - Mathf.Pow(2 * x, 2))) / 2
				: (Mathf.Sqrt(1 - Mathf.Pow(-2 * x + 2, 2)) + 1) / 2;
		}


		const float c1 = 1.70158f;
		const float c2 = c1 * 1.525f;
		const float c3 = c1 + 1f;
		const float c4 = 2 * Mathf.PI / 3;
		const float c5 = 2 * Mathf.PI / 4.5f;

		const float n1 = 7.5625f;
		const float d1 = 2.75f;

		public static float EaseInBack(float x)
		{
			x = Mathf.Clamp01(x);
			return c3 * x * x * x - c1 * x * x;
		}

		public static float EaseOutBack(float x)
		{
			x = Mathf.Clamp01(x);
			return 1 + c3 * Mathf.Pow(x - 1, 3) + c1 * Mathf.Pow(x - 1, 2);
		}

		public static float EaseInOutBack(float x)
		{
			x = Mathf.Clamp01(x);
			return x < 0.5f
				? (Mathf.Pow(2 * x, 2) * ((c2 + 1) * 2 * x - c2)) / 2
				: (Mathf.Pow(2 * x - 2, 2) * ((c2 + 1) * (x * 2 - 2) + c2) + 2) / 2;
		}


		public static float EaseInElastic(float x)
		{
			x = Mathf.Clamp01(x);
			return x <= 0 ? 0 : x >= 1f ? 1f : -Mathf.Pow(2, 10 * x - 10) * Mathf.Sin((x * 10f - 10.75f) * c4);
		}

		public static float EaseOutElastic(float x)
		{
			x = Mathf.Clamp01(x);
			return x <= 0 ? 0 : x >= 1 ? 1 : Mathf.Pow(2, -10 * x) * Mathf.Sin((x * 10f - 0.75f) * c4) + 1f;
		}

		public static float EaseInOutElastic(float x)
		{
			x = Mathf.Clamp01(x);
			return x <= 0 ? 0 :
				x >= 1 ? 1 :
				x < 0.5f ? -(Mathf.Pow(2, 20 * x - 10) * Mathf.Sin((20 * x - 11.125f) * c5)) / 2 :
				(Mathf.Pow(2, -20 * x + 10) * Mathf.Sin((20 * x - 11.125f) * c5)) / 2 + 1;
		}


		public static float EaseInBounce(float x)
		{
			x = Mathf.Clamp01(x);
			return 1 - EaseOutBounce(1 - x);
		}

		public static float EaseOutBounce(float x)
		{
			x = Mathf.Clamp01(x);
			if (x < 1 / d1)
				return n1 * x * x;

			if (x < 2 / d1)
				return n1 * (x -= 1.5f / d1) * x + 0.75f;

			if (x < 2.5 / d1)
				return n1 * (x -= 2.25f / d1) * x + 0.9375f;

			return n1 * (x -= 2.625f / d1) * x + 0.984375f;
		}

		public static float EaseInOutBounce(float x)
		{
			x = Mathf.Clamp01(x);
			return x < 0.5 ? (1 - EaseOutBounce(1 - 2 * x)) / 2 : (1 + EaseOutBounce(2 * x - 1)) / 2;
		}
	}
}
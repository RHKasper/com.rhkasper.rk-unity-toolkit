using UnityEngine;

namespace FloatExtensions
{
    public static class FloatComparison 
    {
        /// <summary>
        /// Evaluates whether two floats are equal within a certain tolerance. Default tolerance is .001f.
        /// </summary>
        public static bool RoughlyEquals(this float f, float other, float tolerance = .001f)
        {
            return Mathf.Abs(f - other) <= Mathf.Abs(tolerance);
        }
    }
}

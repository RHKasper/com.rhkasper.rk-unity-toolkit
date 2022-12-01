using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;

namespace LINQExtensions
{
    public static class LinqMostLeast
    {
        /// <summary>
        /// Finds the element in the given <see cref="collection"/> that evaluates to the greatest value using the
        /// <see cref="valueAssignmentFunction"/>. For example, this could find the player with the most health.
        /// </summary>
        /// <returns>the first element that evaluates to the greatest value with the <see cref="valueAssignmentFunction"/> </returns>
        [Pure] public static T Most<T>(this IEnumerable<T> collection, Func<T, double> valueAssignmentFunction)
        {
            T bestElement = default;
            double bestValue = default;
            bool firstRun = true;

            foreach (T element in collection)
            {
                double tempValue = valueAssignmentFunction.Invoke(element);
                
                if (firstRun || tempValue > bestValue)
                {
                    bestElement = element;
                    bestValue = tempValue;
                    firstRun = false;
                }
            }
            
            return bestElement;
        }
        
        /// <summary>
        /// Finds the element in the given <see cref="collection"/> that evaluates to the least value using the
        /// <see cref="valueAssignmentFunction"/>. For example, this could find the player with the least health.
        /// </summary>
        /// <returns>the first element that evaluates to the least value with the <see cref="valueAssignmentFunction"/> </returns>
        [Pure] public static T Least<T>(this IEnumerable<T> collection, Func<T, double> valueAssignmentFunction)
        {
            T bestElement = default;
            double bestValue = default;
            bool firstRun = true;

            foreach (T element in collection)
            {
                double tempValue = valueAssignmentFunction.Invoke(element);
                
                if (firstRun || tempValue < bestValue)
                {
                    bestElement = element;
                    bestValue = tempValue;
                    firstRun = false;
                }
            }
            
            return bestElement;
        }
    }
}

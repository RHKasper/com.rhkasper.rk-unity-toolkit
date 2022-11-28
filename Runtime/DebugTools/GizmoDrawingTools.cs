using System.Collections.Generic;
using BoundsExtensions;
using UnityEngine;

namespace DebugTools
{
    /// <summary>
    /// This class contains a variety of methods that can be helpful when debugging 3D logic by drawing points and
    /// shapes in gizmos. A couple important notes:
    /// <list type="bullet">
    ///     <item> These get cleared every frame so to see them, you must either call them every frame or call
    ///         <see cref="Debug.Break"/> to pause the editor in the same frame as they are called. </item>
    ///     <item> These rely on Gizmos, so gizmos must be toggled on for them to be visible in the Scene or Game view </item>
    /// </list> 
    /// </summary>
    public static class GizmoDrawingTools
    {
        /// <summary>
        /// Draws a <see cref="point"/> in 3d space by drawing the 6 direction vectors
        /// (up/down, right/left, forward/backward) from that point.
        /// </summary>
        public static void DrawPointInGizmos(this Vector3 point, Color color = default, float lineLength = 1)
        {
            if(color == default)
                color = Color.white;
            
            Debug.DrawRay(point, Vector3.up * lineLength, color);
            Debug.DrawRay(point, Vector3.down * lineLength,  color);
            Debug.DrawRay(point, Vector3.right * lineLength,  color);
            Debug.DrawRay(point, Vector3.left * lineLength,  color);
            Debug.DrawRay(point, Vector3.forward * lineLength,  color);
            Debug.DrawRay(point, Vector3.back * lineLength,  color);
        }
        
        /// <summary>
        /// Draws a <see cref="point"/> in 3d space at a particular <see cref="rotation"/> by drawing the 6 direction vectors
        /// (up/down, right/left, forward/backward) rotated by <see cref="rotation"/>. Colors match Unity transform
        /// tools so red is right, green is up, and blue is forward. 
        /// 
        /// </summary>
        public static void DrawPointAndRotationInGizmos(this Vector3 point, Quaternion rotation, float lineLength = 1)
        {
            Debug.DrawRay(point, rotation * Vector3.up * lineLength, Color.green);
            Debug.DrawRay(point, rotation * Vector3.down * lineLength, Color.white);
            Debug.DrawRay(point, rotation * Vector3.right * lineLength, Color.red);
            Debug.DrawRay(point, rotation * Vector3.left * lineLength, Color.white);
            Debug.DrawRay(point, rotation * Vector3.forward * lineLength, Color.blue);
            Debug.DrawRay(point, rotation * Vector3.back * lineLength, Color.white);
        }

        /// <summary>
        /// Draws a bounding box in world-space aligned with the world axes. 
        /// </summary>
        public static void DrawBoundsInGizmos(this Bounds bounds, Color color = default)
        {
            if(color == default)
                color = Color.white;
            
            var boundPoints = bounds.GetBoundsCorners();
            DrawBoxInGizmos(boundPoints, color);
        }

        /// <summary>
        /// Draws a bounding box in local space aligned with the local axes. This is typically used to draw the
        /// local render bounds of a renderer.
        /// <example>
        ///     renderer.localBounds.DrawLocalBoundsInGizmos(renderer.transform);
        /// </example>
        /// </summary>
        
        public static void DrawLocalBoundsInGizmos(this Bounds bounds, Transform localTo, Color color = default)
        {
            if(color == default)
                color = Color.white;
            
            var boundPoints = bounds.GetLocalBoundsCorners(localTo);
            DrawBoxInGizmos(boundPoints, color);
        }
        
        private static void DrawBoxInGizmos(List<Vector3> vertices, Color color)
        {
            // left side of box (0-1-3-2-0)
            Debug.DrawLine(vertices[0], vertices[1], color);
            Debug.DrawLine(vertices[1], vertices[3], color);
            Debug.DrawLine(vertices[3], vertices[2], color);
            Debug.DrawLine(vertices[2], vertices[0], color);
            
            // right side of box (4-5-7-6-4)
            Debug.DrawLine(vertices[4], vertices[5], color);
            Debug.DrawLine(vertices[5], vertices[7], color);
            Debug.DrawLine(vertices[7], vertices[6], color);
            Debug.DrawLine(vertices[6], vertices[4], color);
            
            // legs (0-4, 1-5, 2-6, 3-7)
            Debug.DrawLine(vertices[0], vertices[4], color);
            Debug.DrawLine(vertices[1], vertices[5], color);
            Debug.DrawLine(vertices[2], vertices[6], color);
            Debug.DrawLine(vertices[3], vertices[7], color);
        }
    }
}
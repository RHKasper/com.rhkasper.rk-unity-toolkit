using System;
using System.Diagnostics.Contracts;
using UnityEngine;

namespace CameraExtensions
{
    public static class CameraPositioning
    {
        /// <summary>
        /// Gets the distance <see cref="cam"/> must be from a sphere of a given <see cref="radius"/> to see it entirely
        /// O(1)
        /// </summary>
        [Pure] public static float GetDistanceToSeeSphere(this Camera cam, float radius)
        {
            // distance = radius / tan(fov/2)
            float fovVert = cam.fieldOfView;
            float fovHoriz = Camera.VerticalToHorizontalFieldOfView(fovVert, cam.aspect);
            float fovMin = Mathf.Min(fovHoriz, fovVert);
            
            float result = radius / Mathf.Sin(Mathf.Deg2Rad * fovMin / 2);
            
            return result;
        }
        
        /// <summary>
        /// Gets the distance <see cref="cam"/> must be from a world-space <see cref="bounds"/> to see it entirely.
        /// O(1)
        /// </summary>
        [Pure] public static float GetDistanceToSeeBounds(this Camera cam, Bounds bounds)
        {
            return cam.GetDistanceToSeeSphere(bounds.extents.magnitude);
        }
        
        /// <summary>
        /// Gets the distance <see cref="cam"/> must be from a <see cref="meshRenderer"/> to see it entirely.
        /// O(n) with respect to the number of vertices in the mesh.
        /// </summary>
        [Pure] public static float GetDistanceToSeeMeshRenderer(this Camera cam, MeshFilter meshFilter, MeshRenderer meshRenderer, out Vector3 centerPoint)
        {
            Transform t = meshRenderer.transform;
            if (meshFilter.transform != t)
                throw new Exception($"{nameof(meshFilter)} and {nameof(meshRenderer)} must be on the same object");
            
            // Find the distance between the bounds center and the furthest point
            float maxSqrDist = 0;
            centerPoint = meshRenderer.bounds.center;
            
            foreach (Vector3 vertex in meshFilter.sharedMesh.vertices)
            {
                Vector3 worldSpaceVert = t.TransformPoint(vertex);
                maxSqrDist = Mathf.Max((centerPoint - worldSpaceVert).magnitude, maxSqrDist);
            }
            
            return cam.GetDistanceToSeeSphere(Mathf.Sqrt(maxSqrDist));
        }

    }
}

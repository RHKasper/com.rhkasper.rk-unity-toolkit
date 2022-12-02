using System.Collections.Generic;
using System.Diagnostics.Contracts;
using UnityEngine;

namespace BoundsExtensions
{
	/// <summary>
	/// Extensions for finding points on a bounding box including the corners and the center of each face
	/// </summary>
	public static class BoundsCornersAndFaces
	{
		/// <summary>
		/// Finds the world-space positions of a world axis aligned bounding box's eight corners.
		/// Order:
		/// <list type="bullet">
			/// <item> 0: Left-Bottom-Back (-x, -y, -z) </item>
			/// <item> 1: Left-Bottom-Front (-x, -y, z) </item>
			/// <item> 2: Left-Top-Back (-x, y, -z) </item>
			/// <item> 3: Left-Top-Front (-x, y, z) </item>
			/// <item> 4: Right-Bottom-Back (x, -y, -z) </item>
			/// <item> 5: Right-Bottom-Front (x, -y, z) </item>
			/// <item> 6: Right-Top-Back (x, y, -z) </item>
			/// <item> 7: Right-Top-Front (x, y, z) </item> 
		/// </list>
		/// </summary>
		/// <param name="bounds"> a bounding box in world space</param>
		[Pure] public static List<Vector3> GetBoundsCorners(this Bounds bounds)
		{
			Vector3 min = bounds.min;
			Vector3 max = bounds.max;
			
			return new List<Vector3>
			{
				new Vector3(min.x, min.y, min.z),
				new Vector3(min.x, min.y, max.z),
				
				new Vector3(min.x, max.y, min.z),
				new Vector3(min.x, max.y, max.z),
				
				new Vector3(max.x, min.y, min.z),
				new Vector3(max.x, min.y, max.z),
				
				new Vector3(max.x, max.y, min.z),
				new Vector3(max.x, max.y, max.z),
			};
		}

		/// <summary>
		/// Find world-space position of the center of each face of a world axis aligned bounding box.
		/// Order:
		/// <list type="bullet">
		/// <item> 0: Left		(-x, 0, 0) </item>
		/// <item> 1: Right		(x, 0, 0) </item>
		/// <item> 2: Bottom	(0, -y, 0) </item>
		/// <item> 3: Top		(0, y, 0) </item>
		/// <item> 4: Back		(0, 0, -z) </item>
		/// <item> 5: Front		(0, 0, z) </item>
		/// </list>
		/// </summary>
		/// <param name="bounds"> a bounding box in world space</param>
		[Pure] public static List<Vector3> GetBoundsFaceCenters(this Bounds bounds)
		{
			Vector3 center = bounds.center;
			Vector3 extents = bounds.extents;
			return new List<Vector3>
			{
				center + new Vector3(-extents.x, 0, 0),
				center + new Vector3(extents.x, 0, 0),

				center + new Vector3(0, -extents.y, 0),
				center + new Vector3(0, extents.y, 0),
				
				center + new Vector3(0, 0, -extents.z),				
				center + new Vector3(0, 0, extents.z),
			};
		}

		/// <summary>
		/// Find world-space positions of the <see cref="localBounds"/>' eight corners.
		/// Order:
		/// <list type="bullet">
		/// <item> 0: Left-Bottom-Back (-x, -y, -z) </item>
		/// <item> 1: Left-Bottom-Front (-x, -y, z) </item>
		/// <item> 2: Left-Top-Back (-x, y, -z) </item>
		/// <item> 3: Left-Top-Front (-x, y, z) </item>
		/// <item> 4: Right-Bottom-Back (x, -y, -z) </item>
		/// <item> 5: Right-Bottom-Front (x, -y, z) </item>
		/// <item> 6: Right-Top-Back (x, y, -z) </item>
		/// <item> 7: Right-Top-Front (x, y, z) </item> 
		/// </list>
		/// </summary>
		/// <param name="localBounds"> a bounding box in local space</param>
		/// <param name="localTo">The transform the bounds are local to</param>
		[Pure] public static List<Vector3> GetLocalBoundsCorners(this Bounds localBounds, Transform localTo)
		{
			Vector3 min = localBounds.min;
			Vector3 max = localBounds.max;
			Matrix4x4 matrix = localTo.localToWorldMatrix;

			return new List<Vector3>
			{
				matrix.MultiplyPoint3x4(new Vector3(min.x, min.y, min.z)),
				matrix.MultiplyPoint3x4(new Vector3(min.x, min.y, max.z)),
				
				matrix.MultiplyPoint3x4(new Vector3(min.x, max.y, min.z)),
				matrix.MultiplyPoint3x4(new Vector3(min.x, max.y, max.z)),
				
				matrix.MultiplyPoint3x4(new Vector3(max.x, min.y, min.z)),
				matrix.MultiplyPoint3x4(new Vector3(max.x, min.y, max.z)),
				
				matrix.MultiplyPoint3x4(new Vector3(max.x, max.y, min.z)),
				matrix.MultiplyPoint3x4(new Vector3(max.x, max.y, max.z)),
			};
		}

		/// <summary>
		/// Find world-space positions of the <see cref="localBounds"/>' six face centers.
		/// Order:
		/// <list type="bullet">
		/// <item> 0: Left		(-x, 0, 0) </item>
		/// <item> 1: Right		(x, 0, 0) </item>
		/// <item> 2: Bottom	(0, -y, 0) </item>
		/// <item> 3: Top		(0, y, 0) </item>
		/// <item> 4: Back		(0, 0, -z) </item>
		/// <item> 5: Front		(0, 0, z) </item>
		/// </list>
		/// </summary>
		/// <param name="localBounds"> a bounding box in local space</param>
		/// <param name="localTo">The transform the bounds are local to</param>
		[Pure] public static List<Vector3> GetLocalBoundsFaceCenters(this Bounds localBounds, Transform localTo)
		{
			Matrix4x4 matrix = localTo.localToWorldMatrix;

			Vector3 center = localBounds.center;
			Vector3 extents = localBounds.extents;

			return new List<Vector3>
			{
				matrix.MultiplyPoint3x4(center + new Vector3(-extents.x, 0, 0)),
				matrix.MultiplyPoint3x4(center + new Vector3(extents.x, 0, 0)),
				
				matrix.MultiplyPoint3x4(center + new Vector3(0, -extents.y, 0)),
				matrix.MultiplyPoint3x4(center + new Vector3(0, extents.y, 0)),
				
				matrix.MultiplyPoint3x4(center + new Vector3(0, 0, -extents.z)),
				matrix.MultiplyPoint3x4(center + new Vector3(0, 0, extents.z)),
			};
		}
	}
}
# Changelog

All notable changes to this project will be documented in this file.

The format is based on [Keep a Changelog](https://keepachangelog.com/en/1.0.0/),
and this project adheres to [Semantic Versioning](https://semver.org/spec/v2.0.0.html).

## [2.0.1] - 2025-01-10
### Added
- GetComponentExtensions: Added GetComponentsInDirectChildren methods

## [2.0.0] - 2024-12-08
### Added
- GenericListDisplay: UI Component for displaying a list of objects. Good for rapid UI prototyping/development.
- UGuiTools: a set of useful editor tools for uGUI. See Third Party Notices.md for attribution info
- WhiteSquare256.png: added a white square sprite
### Updated
- Fixed Easing Samples

## [1.0.3] - 2022-12-20
### Added
- Vector2 Extensions
  - Vector2Multiply.cs: extensions for multiplying Vector2s together in a component-wise fashion
  - Vector2ToVector3.cs: extensions for converting a Vector2 to a Vector3 with reorganized components
- Vector2IntExtensions
  - Vector2IntMultiply.cs: extensions for multiplying Vector2Ints together in a component-wise fashion
  - Vector2IntToVector3Int.cs: extensions for converting a Vector2Int to a Vector3Int with reorganized components
- Vector3Extensions
  - Vector3Multiply.cs: extensions for multiplying Vector3s together in a component-wise fashion
  - Vector3ToVector2.cs: extensions for converting a Vector3 to a Vector2 with reorganized components
- Vector3IntExtensions:
  - Vector3IntMultiply.cs: extensions for multiplying Vector3Ints together in a component-wise fashion
  - Vector3IntToVector2Int.cs: extensions for converting a Vector3Int to a Vector2Int with reorganized components
- MathConstants: precalculated math constants for convenience and improved performance

## [1.0.2] - 2022-12-1
### Updated
- Added `Pure` attribute to methods within the toolkit that return a value without modifying the state of anything.
- Added Changelog badge to README.md
- Modifications to `BoundsCornersAndFaces.cs` to throw an exception when a null `Transform` is passed.
- Minor documentation updates

## [1.0.1] - 2022-11-30
### Updated
- README file updated to include toolkit logo

## [1.0.0] - 2022-11-29

### Added
- Bounds Extensions
  - BoundsCornersAndFaces.cs: extensions for finding points on a bounding box
- Camera Extensions
  - CameraPositioning.cs: extensions for positioning a camera to see an object
- Color Extensions
  - ColorEditComponents.cs: extensions for copying a color and replacing components on the copy
- DebugTools
  - GizmoDrawingTools.cs: debug tools for drawing points and bounds in gizmos
- Easing
  - EasingFunctions.cs: C# implementations of all the easing functions on easings.net
  - EasingType.cs: an enum representing all the easing functions on easings.net
  - EasingUtil.cs: an interface for accessing the easing functions contained in this package 
- FloatExtensions
  - FloatComparison.cs: extensions for float comparison
  - FloatRemap.cs: extensions for remapping float values
- GenericsExtensions
  - ArrayExtensions.cs: extensions for populating an array or getting a random element
- GraphicExtensions
  - GraphicEditColorComponents.cs: shortcuts for the methods in ColorEditComponents.cs
- LINQExtensions
  - LinqMostLeast.cs: LINQ methods to get the element in a collection that has the most or least of something (i.e. get the player with the most health)
- TestTemplates
  - EditorTestExample.cs: a sample editor test script
- TestTemplates
  - RuntimeTestExample.cs: a sample runtime test script
- Vector2Extensions
  - Vector2Adjustments.cs: extensions for adjusting the values in a Vector2 (Clamp, Min, Max, Abs, etc.)
  - Vector2Components.cs: extensions for rearranging or removing the components in a Vector2 (XO, YX, YY, etc.)
  - Vector2EditComponents.cs: extensions for editing the component values of a Vector2 (WithX, WithY)
  - Vector2Rounding.cs: extensions for rounding a Vector2
- Vector2IntExtensions
  - Vector2IntAdjustments.cs: extensions for adjusting the values in a Vector2Int (Clamp, Min, Max, Abs, etc.)
  - Vector2IntComponents.cs: extensions for rearranging or removing the components in a Vector2Int (XO, YX, YY, etc.)
  - Vector2IntEditComponents.cs: extensions for editing the component values of a Vector2Int (WithX, WithY)
- Vector3Extensions
  - Vector3Adjustments.cs: extensions for adjusting the values in a Vector3 (Clamp, Min, Max, Abs, etc.)
  - Vector3Components.cs: extensions for rearranging or removing the components in a Vector3 (XOZ, YYZ, XYO, etc.)
  - Vector3EditComponents.cs: extensions for editing the component values of a Vector3 (WithX, WithY, WithZ)
  - Vector3Rounding.cs: extensions for rounding a Vector3
- Vector3IntExtensions
  - Vector3IntAdjustments.cs: extensions for adjusting the values in a Vector3Int (Clamp, Min, Max, Abs, etc.)
  - Vector3IntComponents.cs: extensions for rearranging or removing the components in a Vector3Int (XOZ, YYZ, XYO, etc.)
  - Vector3IntEditComponents.cs: extensions for editing the component values of a Vector3Int (WithX, WithY, WithZ)


[unreleased]: https://github.com/RHKasper/com.rhkasper.rk-unity-toolkit/compare/main...develop
[2.0.0]: https://github.com/RHKasper/com.rhkasper.rk-unity-toolkit/releases/tag/2.0.0
[1.0.3]: https://github.com/RHKasper/com.rhkasper.rk-unity-toolkit/releases/tag/1.0.3
[1.0.2]: https://github.com/RHKasper/com.rhkasper.rk-unity-toolkit/releases/tag/1.0.2
[1.0.1]: https://github.com/RHKasper/com.rhkasper.rk-unity-toolkit/releases/tag/1.0.1
[1.0.0]: https://github.com/RHKasper/com.rhkasper.rk-unity-toolkit/releases/tag/1.0.0

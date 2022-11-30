[![openupm](https://img.shields.io/npm/v/com.rhkasper.rk-unity-toolkit?label=openupm&registry_uri=https://package.openupm.com)](https://openupm.com/packages/com.rhkasper.rk-unity-toolkit/)


![RK Unity Toolkit Logo Wide-min](https://user-images.githubusercontent.com/98301621/204843781-56d493d1-5060-493d-9ffe-ff4518a0c6a0.png)

# Welcome to the RK Unity Toolkit

The RK Unity Toolkit is an open source library of extension methods and tools that make solving many common problems in Unity cleaner, faster, and easier. Some highlights include:
- Easing Functions - Unity implementations of all the functions described on easings.net. These are very useful for code-based animations and creating polished non-linear behaviors.
- Vector Extensions - A lot of common vector operations like taking the absolute value, clamping, and removing components are tedious and verbose in Unity. These extensions simplify most operations into a single statement that’s easy to read.
- Gizmo Drawing Tools - A collection of tools for drawing points and bounding boxes in Unity’s gizmos, making it easier to debug 3D math.

## How to use it
The easiest way to add the RK Unity Toolkit to a Unity project is with the Unity Package Manager's "Add package from git URL..." option and entering "https://github.com/RHKasper/com.rhkasper.rk-unity-toolkit.git" in the text field.

This package is also available on OpenUPM: https://openupm.com/packages/com.rhkasper.rk-unity-toolkit/

![image](https://user-images.githubusercontent.com/98301621/204426785-c018e2a4-2df5-4a8a-be9a-95c9c7612893.png)


## Versioning
Each number in a release version will represent changes of different magnitude:

- Major Version (1.3.35 => 2.0.0): changes in the first number represent major changes to the toolkit that will very likely cause errors in existing usage. This will include:
   - Unity major version updates (2021.3.x => 2022.3.x)
   - Renaming methods
   - Deleting methods (I don't expect to do this often, but it could happen)


- Medium Version (1.3.35 => 1.4.0): changes in the second number represent moderate changes. These likely won't cause any errors in existing usage, but if they do, they will be easy to resolve using a modern IDE like Visual Studios or Rider. Examples:
   - Unity minor version updates (2021.3.12f1 => 2021.3.15f1)
   - Reorganization of extension methods and files
   - namespace changes


- Minor Version (1.3.35 => 1.3.36): changes in the third number represent minor changes and bug fixes. These will not cause errors in existing usage. Examples:
   - Addition of new files or methods
   - Documentation updates
   - Bug fixes (hopefully these won't be needed very often)

## License
The RK Unity Toolkit uses the Unlicense meaning it is totally free for anyone to use, no strings attached. Please consult the LICENSE file for details.

## Contact me
Feel free to contact me using Discord (Robert#4580) or email (roberthkasper@gmail.com) if you have any questions, comments, or suggestions. Happy coding!

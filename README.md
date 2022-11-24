# ReadMe

In this project we used MRTK Built-in packages to detect both left and right hand joints in hololens 2. <a href="https://github.com/shshjmakerspace/UnityHandTracking/blob/master/HandTracking.cs">This</a> is the main Unity script. <br />
More details on ...
- <a href="https://microsoft.github.io/MixedRealityToolkit-Unity/Documentation/Input/HandTracking.html">MRTK Document (Old Version) </a>  


- <a href="https://learn.microsoft.com/en-us/dotnet/api/microsoft.mixedreality.toolkit.input.handjointutils.trygetjointpose?view=mixed-reality-toolkit-unity-2020-dotnet-2.8.0">MRTK Document (New Version) </a>  

- <a href ="https://www.youtube.com/watch?v=BKJ6sjJ9oao">Youtube Basic Tutorial </a>
- Note for me: HandJoints are defined as Enum. So, to be able to get the index of different values in enum (for more compact coding using loop) we need to cast the "i" which is our indexing variable to "TrackedHandJoint"

# Demo

<img src="https://github.com/shshjmakerspace/ArduinoUnity3D/blob/main/Arduino%20Unity3D%20Serial%20Communication/-media/step4-3.gif" width="700"/>
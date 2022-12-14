# SOFAtoUNITY_VRviewer
### Unity project allowing the user to view in a simple VR environment an animated object (format .blend, .fbx ...) with ready-to-use and configurable textures, lights, wireframe shader etc...


![image](https://user-images.githubusercontent.com/94963203/181261550-9eb2bc57-b19f-403d-b573-b8846b0ee3da.png)



## How to use
Download the zip file, unzip it and add the folder to the Unity Hub as a project.

Once in the project, make sure to configure the project settings for your specific VR device.
The project is currently configured for Oculus Quest but can normally be used with any device.

(NOTE : For the use of Oculus, go to Project Settings > XR Plugin Management > Open XR and in the dropdown Play Mode OpenXR Runtime choose 'Oculus' and don't check 'Mock Runtime')
![image](https://user-images.githubusercontent.com/94963203/181239507-6be9fdeb-54cb-447c-8588-e0c0aa209509.png)

Once the project is configured correctly, connect your VR device via cable to your PC, and press play in Unity, you should now be in the scene with some examples of animated models coming from SOFA.

(NOTE : More precisely for Oculus, connect your device via cable then in the Headset go to Quick Parameters > Oculus Link and once the Oculus Link is active you just need to press play on Unity (in the Editor) and the scene will be running in the Headset)

## What you can do

To see what you can do on this project, refer to the SOFAtoUNITY project : https://github.com/DHS5/SOFAtoUNITY

To interact with the UI, simply use the index trigger of your VR controller, and to teleport yourself, use the midlle finger trigger on the colored carpet (you'll see where you can teleport thanks to reticles on the carpet).


Note that the functionnalities that follow aren't enabled in the VR viewer :
* Camera movements thanks to shortcuts (obviously)
* FBX Scene Recording
* Light Preset Creation (Light presets need to be created in the Editor manualy)
* Background management

But of course the VR point of view offers possibilities and degrees of liberty compared to the 2D screen view which more than compensate those losses.

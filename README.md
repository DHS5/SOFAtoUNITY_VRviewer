# SOFAtoUNITY_VRviewer
### Unity project allowing the user to view in a simple VR environment an animated object (format .blend, .fbx ...) with ready-to-use and configurable textures, lights, wireframe shader etc...


## How to use
Download the zip file, unzip it and add it to the Unity Hub.

Once in the project, make sure to configure the project settings for your specific VR device.
The project is currently configured for Oculus Quest but can normally be used with any device.

(NOTE : For the use of Oculus, go to Project Settings > XR Plugin Management > Open XR and in the dropdown Play Mode OpenXR Runtime choose 'Oculus' and don't check 'Mock Runtime')
![image](https://user-images.githubusercontent.com/94963203/181239507-6be9fdeb-54cb-447c-8588-e0c0aa209509.png)

Once the project is configured correctly, connect your VR device via cable to your PC, and press play mode, you should now be in the scene with some example animated models.

(NOTE : More precisely for Oculus, connect your device via cable then in the Headset go to Quick Parameters > Oculus Link and once the Oculus Link is active you just need to press play on Unity (in the Editor) and the scene will be running in the Headset)

## What you can do

To see what you can do on this project, refer to the SOFAtoUNITY project : https://github.com/DHS5/SOFAtoUNITY

Note that the functionnalities that follow aren't enabled in the VR viewer :
* FBX Scene Recording
* Light Preset Creation (Light presets need to be created in the Editor manualy)
* Background management

But of course the VR point of view offers possibilities and degrees of liberty compared to the 2D screen view which more than compensate those losses.

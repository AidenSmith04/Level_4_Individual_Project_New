# Readme

File Structure:
* images - Stores the 2D images for the art
* Imported Models - Stores the raw downloaded versions of the imported models
* Materials - Stores materials for objects. It is important to note that the 2D art is converted into a Material so that it can applied to the frame
* Oculus - Native with the meta quest project
* Plugins - Stores android data, you shouldn't need to change anything here
* Prefabs - Stores the prefabs that can be placed in the different conditions
* Resources - You shouldn't have to change this
* Scenes - Only contains the main scene, but more scenes can be added
* Scripts - Contains the non-package scripts used in this project
* Streaming Assets - You shouldn't need to change this, native unity storage
* TextMeshPro - Needs to be here to use text, shouldn't need to change
* XR - Needs to be here to run XR, shouldn't need to change

The code itself allows you to place a prefab in real space and then walk around the area.

## Build instructions

The Manifest file should automatically install all packages automatically. But if it does not you will need android build support and ARCore. You will also need the Meta XR All-in-One SDK (The specific version used in this project was v69.0.1).

You must also alter the package script called SpatialAnchorSpawnerBuildingBlock (Can be found in Packages/Meta XR Core SDK/Scripts/BuildingBlocks/SampleSpatialAnchorControllerScripts). You need to replace the code with the code contained in the file SpatialAnchorSpawnerBuildingBlockChanged (Located in the root folder).

You can build this using a USBC to USB adapter plugging in the computer and the Meta Quest 3 headset. You must then build and run through the file menu in the top left.

### Requirements

* Meta Quest 3 Headset
* Packages: Should Be handled by the manifest file, otherwise, android build support and ARCore. You will also need the Meta XR All-in-One SDK (The specific version used in this project was v69.0.1).
* Unity v6000.0.26f1

### Build steps

You can build this using a USBC to USB adapter plugging in the computer and the Meta Quest 3 headset. You must then build and run through the file menu in the top left. Please note that you will have to put your headset into developer mode and disable the spatial features

### Test steps

To test this application, you should run the app in the headset. You should then test all of the conditions in each of the locations as described in the appendix of the dissertation. You should be able to place the art in the locations and then walk around the space and see the art.

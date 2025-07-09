# Unity-Media-Player
A basic media player app made in Unity.

**NOTE:** This app was built with Unity editor 2022.3.2f1. Older/newer versions of the editor may not be compatible with the source.

## Things to know
- **Quad:** Used as a projector for the VideoPlayer component in Unity. Do not use a plane, as its orientation is flipped compared to a Quad, so the video will display upside down, and there aren't many beginner-friendly ways to fix that.
- **Canvas:** Used for UI buttons, such as Play/Pause, forward and rewind, URL input, and more. All the text on these buttons uses TextMeshPro, not the legacy 3D Text, so you will need to install TextMeshPro (which you will be prompted to do).
- **Directional Light:** Previously used for lighting. Replaced with VideoMaterial.
- **VideoMaterial:** The material used for lighting on the video player. It prevents lighting changes caused by Directional Light.

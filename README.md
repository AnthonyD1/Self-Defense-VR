# Self-Defense-VR
A virtual self-defense experience geared towards those who do not know much about self-defense and wish to learn. **Disclaimer**: This is not meant to be a replacement of proper self-defense education, it is purely supplementary and for educational purposes only. Please seek a qualified professional if self-defense advice is needed.

## Table of Contents:
- [Introduction](#introduction)
- [Video Demo](#demo)
- [Poster](#poster)
- [Setup](#setup)
- [Controls](#controls)
- [Known Bugs](#bugs)
- [Resources](#resources)

## Introduction
Welcome to Self-Defense VR! 
  This virtual reality experience was developed by Anthony Delgado Pimental, Jacob Norris, Salem Ozaki, & Jordan Proby with voiceover additions by Paul Demange. This project was created during their time at Cornell College for their Computer Science Topics Class on Virtual Reality. This VR experience was created so that aspiring self-defense enthusiasts could hopefully practice their skills without having to invest the time or money in a training gym or certified instructor. 
  This version of the project has limited functionality, but allows the user to run Drills and learn punch movements in various Tutorials. Punches, Hooks, and Uppercuts where the punches implemented.
  
## Demo
This Demo showcases the different features users can experience within our VR project. This includes:
- Trainer voice instructions
- Paths for punch guidance
- Ambient/interaction sound for emersion
- Telelportation or ThumbStick locomotion
- Animated models for punch instruction

[![HUD Demo](http://img.youtube.com/vi/nsHNmOCuyps/0.jpg)](https://youtu.be/nsHNmOCuyps)

## Poster
Please click on the image below to see our full poster presentation to get a general idea of the functionality of this project.
![Poster](https://github.com/AnthonyD1/Self-Defense-VR/raw/master/Self-Defense-Poster.png "Poster")

## Setup
You will need:
- Unity 2017.3.1
- Visual Studios 2017 (could opt for a different text editor of you choosing)
- The free assets and libraries specified under [Resources](#resources)
- Oculus Rift and related peripherals

To play our game you have two options:
1. Clone our repository (allows user to modify code and work on project)
- Clone the repository like you would any other
- Open the project with unity
- Within Unity, run the game from any game scene
- Make sure your Oculus Rift is connected and functional
- Alternatively, you could build the all the scenes (make sure all scenes except "Animation Testing"are in the build manager)

2. Play the executable (allows user to run an executable without needing the whole repository)
- Download the newest release of our project from the "releases" tab of Github
- Make sure the .exe, .ddl and zip file are in the same directory
- unzip the .zip file
- Launch the .exe

## Controls
#### Movement
- Use Gaze Teleport: hold the "B" button on the right Touch controller, look at where you want to teleport (there will be a reticle) and pull trigger to teleport.
- Walking locomotion: use the left thumbstick to move about, and the right Thumbstick to rotate head 45 degrees left or right.

#### Fist
To make a fist hold the Trigger and Grip buttons, then place your thumb over the "A", "b" or Thumbstick button. Do this with both cotnrollers.


## Bugs
1. The player can currently walk on top of the standing punching bag. This can be disorienting for new users. To avoid, try to use teleportation exclusively and walking locomotion for micro-adjustments of position.
2. There are issues with audio clips overlapping with each other when the player interacts with Boris. This is most common when the user is colliding with his pads.
3. The user can currently teleport to a wall and stick their head through the wall and see the outside. To avoid this a collider could be added to the player's head.

## Resources
  There are assests to this project that we did not make but that we downloaded for free from the Unity Asset Store. In order to correctly clone, compile, and run this repository, you will need the following free assets (they are included in our repository):
  
  Boris the CageFighter: https://goo.gl/rwdPAK
  
  Fighting Motions Vol. 1: https://goo.gl/4hc27U
  
  Standing Punching bag: https://goo.gl/eqkhHe
  
  Speed bag: https://goo.gl/iNSND4
  
  OVR Utilities/Platform/Avatar: https://goo.gl/JNCKUu
  - Simply Download the corresponding packages, then import the .unityPackage files into your project (these will be located inside various files for each package). For a full tutorial see: https://www.youtube.com/watch?v=sxvKGVDmYfY (only watch the parts on the packages).
  
  Teleportation: https://www.youtube.com/watch?v=qjW4_1of7u4
  - We used this tutorial as the base for out gaze teleportation but heavily modified it to be compatible with the Oculus' Touch controllers.
  
  Inspiration for punch paths: https://vimeo.com/252023110



# My sad attempt at creating Voice Activated AR Car Show Application

Project Worker: Eun Kyung Yoon

Date: 2019-09-23

### Sad Description

This tutorial aims to create an AR Car show that is activated by voice. I chose this project because it implemented a variety of tech from machine learning, voice recognition to augmented reality.

A successful execution of this project would have created an android application where I can choose a model of a car, see the selected car in AR (either outside or inside buildings), make the car model move through my voice.

Following the tutorial, I managed to create a scene where the camera shows a 3d model of a car when the camera identifies its image (had a basic experience with how Vuforia worked with Unity). Then, I set up the "start" screen where I can choose which car I want to see in AR. Then, I visited wit.ai to teach the algorithm commands like "open the bonnet", "close the windows" and more so that I can use my voice to later activate animations in the 3d models.

### What I learned

* How to teach an algorithm in a balanced way so as to teach them how to recognize sentence patterns

* A big picture of how Vuforia integrates into Unity (generally how Vuforia works)

* Practiced developing UI for Unity (through canvas, UI, buttons, animations etc.)

* How to create particle motion using prewritten features in Unity

* 10 hours tutorial time does not mean 10 hours of work time

### What I couldn't achieve

For some reason, there was a major bug in the Vuforia package. I simply could not link the "start" screen with the second scene where the AR car models appear. "Cannot initialize Vuforia", "cannot recognize Vuforia packages" etc. were some of the bugs that I ran across as I tried to fix it. But more I tried to fix, the weirder it got. Sometimes just reopening Unity fixed the bugs.

I even scaled down the project so that it does not have any of the voice activated parts. But because loading the scene itself was impossible, the plan failed.

### Sad Tutorial

https://www.lynda.com/Unity-tutorials/Preparing-connect-Unity-cloud-based-AI-part-1/802860/2802241-4.html

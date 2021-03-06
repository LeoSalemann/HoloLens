﻿# Dead Switch Live:  Bringing Dead Switches to Life
A Seattle VR Hackathon Project, September 16-18, 2016

## Inspiration
The Museum of Flight in Seattle has a few "sit in cockpit" exhibits. You can climb into an actual jet cockpit, settle into the seat, grab the stick, turn some knobs ..... and nothing happens.  What if you wore an AR headset that could "paint over" the gauges and make them come to life?  What i you could paint over the windshield to render the simulated world running past you, pitching and rolling as yank and bank on the stick?  What if this could be done without making any physical changes to the exhibit?

And what if this technology where available to every exhibitor for every museum and tradeshow?

## Operating Concept
An AR System would track hand/finger position, and render graphics to guages, windshields, portholes, etc; to show how the (simulated) vehicle reacts to the switches and wheel. Sounds would include engine noise, wind/water/ground effects, etc.

Perhaps an AI/Machine Learning system could watch your hands and be ‘trained’ on how to react to manipulations of the physical switches.  Imagine climbing into a real airplane, grabbing the stick and moving it forward and back.  At the same time, someone is operating a USB joystick in unison with your motions.  The AI/Machine Learning System watches (with a couple strategically placed webcams) and learns that “This Motion” means “That USB axis”  Simlar with switches.  “This physical switch” means “that keyboard press”  Hit the switch and keyboard in unison until the AI gets it.  With an AI like that, BDSTL could be "trained" to work with any exhibit, control panel, or vehicle anywhere.

## What Has Been Built So Far
The first iteration consists of a Microsoft HoloLens App, a physticals slider switch, and "holographic twin" of the slider switch, rendered in glowing wireframe.  The user begins by placing the phystical slider switch on a work surface such as a desk.  The next step is to launch the HoloLens App, which will render the holograpic twin floating in the air, about a meter away from the user. The user grabs the slider with the standard HoloLens "pinch" gesture, then places it over its phystical twin so that they correleate. You can see photographs of this effect on my [devpost.com project page](http://devpost.com/software/bringing-dead-switches-to-live-bdstl) The slider button is a seprate object, which must also be placed to correlate with its physical twin.  I was hoping the button could be configured to follow the users hand/fingers rather than gaze. In practice, this doesn't work very well, as the user needs to stare at the slide button while moving it. I have an idea of how to make it work better, though.  Check out my [whole story on github](https://github.com/LeoSalemann/BDSTL/blob/master/TheWholeStory.md) and/or [devpost](http://devpost.com/software/bringing-dead-switches-to-live-bdstl).

## How I built it

This project is built from the code base associated with the Holograms 101 course at [https://developer.microsoft.com/en-us/windows/holographic/holograms_101e]. It contains all the conent from all the chapters, plus numerous modifications to achive the BDSTL goals. The original Origami geometry is still there, just diabled.  A few scripts were changed, a couple added.  The development branch was tagged for (almost) each step of the tutorial as well as the demo releases, so you can diff some versions against eachother to see what I changed.

The geometry was built in Unity; the scripting done in C#.  The Unity content was  exported to Visual Studio to run on the HoloLense emulator. A special version of unity had to be installed, refernced at the [Windows Dev Center for HoloLens](https://developer.microsoft.com/en-us/windows/holographic/install_the_tools). All of this ran on a Surface Pro which the Seattle VR Hackathon generously loaned out. Two iteratons of the project were successfuly  deployed to an actual HoloLens.  


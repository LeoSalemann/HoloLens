﻿# BDSTL
Bringing Dead Switches to Life

This line of text was made in the dev branch.  It is hopefully invisible from master.
This line of text was made via a web browser.  At this point, I've commeited a stripped-down version of the Origami project frorm the Holograms 101e totorial from developer.microsoft.com. As I go through the chapters, I'll commit my changes each time.

## Inspiration
The Museum of Flight in Seattle has a few "sit in cockpit" exhibits. You can climb into an actual jet cockpit, settle into the seat, grab the stick, turn some knobs ..... and nothing happens.  What if you wore an AR headset that could "paint over" the gauges and make them come to life?  What i you could paint over the windshield to render the simulator world running past you, pitching and rolling as yank and bank on the stick?  What if this could be done without making any physical changes to the exhibit?

And what if this technology where available to every exhibitor for every museum and tradeshow?

## What it does
An AR System would track hand/finger position, and render graphics to the ‘green screen’ areas to show how the (simulated) vehicle reacts to the switches and wheel. Physical gauges would be “overwritten” by virtual gauges that came to life.  An out the window scene would get rendered onto the windshield. Sound would be there too.

Perhaps an AI/Machine Learning system could watch your hands and be ‘trained’ on how to react to manipulations of the physical switches.  Imagine climbing into a real airplane, grabbing the stick and moving it forward and back.  At the same time, someone is operating a USB joystick in unison with your motions.  The AI/Machine Learning System watches (with a couple strategically placed webcams) and learns that “This Motion” means “That USB axis”  Simlar with switches.  “This physical switch” means “that keyboard press”  Hit the switch and keyboard in unison until the AI gets it.  With an AI like that, BDSTL could be "trained" to work with any exhibit, control panel, or vehicle anywhere.

## How I built it
This project is built on the Holgrams 101e tutorial materials at [https://developer.microsoft.com/en-us/windows/holographic/holograms_101e] . That's why the project is called Origami and lives under a folder called HolographicAcademy-Holograms-101

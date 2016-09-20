## Inspiration
The Museum of Flight in Seattle has a few "sit in cockpit" exhibits. You can climb into an actual jet cockpit, settle into the seat, grab the stick, turn some knobs ..... and nothing happens.  What if you wore an AR headset that could "paint over" the gauges and make them come to life?  What i you could paint over the windshield to render the simulator world running past you, pitching and rolling as yank and bank on the stick?  What if this could be done without making any physical changes to the exhibit?

And what if this technology where available to every exhibitor for every museum and trade show?

## Operating Concept
An AR System would track hand/finger position, and render graphics to guages, windshields, portholes, etc; to show how the (simulated) vehicle reacts to the switches and wheel. Sounds would include engine noise, wind/water/ground effects, etc.

Perhaps an AI/Machine Learning system could watch your hands and be ‘trained’ on how to react to manipulations of the physical switches.  Imagine climbing into a real airplane, grabbing the stick and moving it forward and back.  At the same time, someone is operating a USB joystick in unison with your motions.  The AI/Machine Learning System watches (with a couple strategically placed webcams) and learns that “This Motion” means “That USB axis”  Simlar with switches.  “This physical switch” means “that keyboard press”  Hit the switch and keyboard in unison until the AI gets it.  With an AI like that, BDSTL could be "trained" to work with any exhibit, control panel, or vehicle anywhere.

## What Has Been Built So Far
The first iteration consists of a Microsoft HoloLens App, a physticals slider switch, and "holographic twin" of the slider switch, rendered in glowing wireframe.  The user begins by placing the phystical slider switch on a work surface such as a desk.  The next step is to launch the HoloLens App, which will render the holograpic twin floating in the air, about a meter away from the user. The user grabs the slider with the standard HoloLens "pinch" gesture, then places it over its phystical twin so that they correleate. You can see photographs of this effect on my [devpost.com project page](http://devpost.com/software/bringing-dead-switches-to-live-bdstl) The slider button is a seprate object, which must also be placed to correlate with its physical twin.  I was hoping the button could be configured to follow the users hand/fingers rather than gaze. In practice, this doesn't work very well, as the user needs to stare at the slide button while moving it. I have an idea of how to make it work better, though.  Keep reading ...

## How I built it
The geometry was built in Unity; the scripting done in C#.  The Unity content was  exported to Visual Studio to run on the HoloLense emulator. A special version of unity had to be installed, refernced at the [Windows Dev Center for HoloLens](https://developer.microsoft.com/en-us/windows/holographic/install_the_tools). All of this ran on a Surface Pro which the Seattle VR Hackathon generously loaned out. Two iteratons of the project were successfuly  deployed to an actual HoloLens. The code & content is based  on the Holgrams 101e tutorial materials at [https://developer.microsoft.com/en-us/windows/holographic/holograms_101e] . That's why the project is called Origami and lives under a folder called HolographicAcademy-Holograms-101.  The original Origami geometry is still there, just diabled.  A few scripts were changed, a couple added.  The development branch was tagged for (almost) each step of the tutorial as well as the demo releases, so you can diff some versions against eachother to see what I changed. 


## Challenges I ran into
Another challenge is the fact that the emulator can't pull in imagery of the real world. Was hoping to be able to do that through a webcam.

So, looks like I'll need to replicate my physical device in unity, so HoloLens has a holographic version of it to interact with. If I place the physical device so it spatially-correlates with the holographic one, then hopefully HoloLens can track hand gestures as they collide with the holographic device, while physical collisions just happen.

Ran into a Visual Studio Build error, unable to find Assembly-CSharp.dll. Happened after moving my Unity project from one folder to another. Tried googling around and trying a few things (see my trello log) to no avail.  Bharat suggested that I *Delete and rebuild my App folder* and that made all the difference ... it worked!

## Accomplishments that I'm proud of
Grateful to Seattle VR, Slack, and Devpost for providing such a cool venue for my idea!

## What I learned
Choose your HoloLens Tutorials carefully. The best one I found so far is Holograms 101e. Includes some sample Unity Projects which are well-configured for HoloLens use.

A USB-enabled game pad was very helpful. 

## Useful Links 
[Holograms 101E: Best Unity/HoloLens Course Ever!] (https://developer.microsoft.com/en-us/windows/holographic/holograms_101e)
[Unity - Colliders as Triggers] (https://unity3d.com/learn/tutorials/topics/physics/colliders-triggers)

## What's next for Bringing Dead Switches To Live (BDSTL)

** Maybe I only need collision volumes ...

The *real* workflow would work something like this ....
1) Start with a holographic twin, like what I made.
2) Move and place it to correlate with the physical, like I did.
4) Turn the rendering off, leave the collision volumes there.
5) All the interactivity happens by colliding gaze with collision volumes.  Button-moving has nothing to do with it ....
6) Although, it might be nice if you could see holographic switches move, but none of this free-floating stuff.  The holo-switch would move (toggle flips, sliders slides) and you "chase it" with the physical switches.

See my backlog list on my Trello.  Also, would like to transition to Submarine and Aircraft projects.

## Inspiration
The Museum of Flight in Seattle has a few "sit in cockpit" exhibits. You can climb into an actual jet cockpit, settle into the seat, grab the stick, turn some knobs ..... and nothing happens.  What if you wore an AR headset that could "paint over" the gauges and make them come to life?  What i you could paint over the windshield to render the simulator world running past you, pitching and rolling as yank and bank on the stick?  What if this could be done without making any physical changes to the exhibit?

And what if this technology where available to every exhibitor for every museum and tradeshow?

## What it does
An AR System would track hand/finger position, and render graphics to the ‘green screen’ areas to show how the (simulated) vehicle reacts to the switches and wheel. Physical gauges would be “overwritten” by virtual gauges that came to life.  An out the window scene would get rendered onto the windshield. Sound would be there too.

Perhaps an AI/Machine Learning system could watch your hands and be ‘trained’ on how to react to manipulations of the physical switches.  Imagine climbing into a real airplane, grabbing the stick and moving it forward and back.  At the same time, someone is operating a USB joystick in unison with your motions.  The AI/Machine Learning System watches (with a couple strategically placed webcams) and learns that “This Motion” means “That USB axis”  Simlar with switches.  “This physical switch” means “that keyboard press”  Hit the switch and keyboard in unison until the AI gets it.  With an AI like that, BDSTL could be "trained" to work with any exhibit, control panel, or vehicle anywhere.

## How I built it
Using unity and HoloLense so far. Using the hollow lens emulator on a Microsoft Surface Pro. I started with the demo unity project from Holograms 101e from the microsoft developer site.  I disabled a bunch of content, created my on unity models, and modified a few C# scripts.

## Challenges I ran into
Another challenge is the fact that the emulator can't pull in imagery of the real world. Was hoping to be able to do that through a webcam.

So, looks like I'll need to replicate my physical device in unity, so Hololens has a holographic version of it to interact with. If I place the physical device so it spatially-correlates with the holographic one, then hopefully Hololense can track hand gestures as they collide with the holographic device, while physical collisions just happen.

Ran into a Visual Studio Build error, unable to find Assembly-CSharp.dll. Happened after moving my Unity project from one folder to another. Tried googling around and trying a few things (see my trello log) to no avail.  Bharat suggested that I *Delete and rebuild my App folder* and that made all the difference ... it worked!

## Accomplishments that I'm proud of
Grateful to Seattle VR, Slack, and Devpost for providing such a cool venue for my idea!

## What I learned
Choose your Hololense Tutorials carefully. The best one I found so far is Holograms 101e. Includes some sample Unity Projects which are well-configured for HoloLens use.

A USB-enabled game pad was very helpful. 

## Useful Links 
[Holograms 101E: Best Unity/HoloLens Course Ever!] (https://developer.microsoft.com/en-us/windows/holographic/holograms_101e)
[Unity - Colliders as Triggers] (https://unity3d.com/learn/tutorials/topics/physics/colliders-triggers)

## What's next for Bringing Dead Switches To Live (BDSTL)

** Maybe I only need collision volumes ...

The *real* workflow would work something like this ....
1) Start with a holographic twin, like what I made.
2) Move and place it to correlate with the physial, like I did.
4) Turn the rendering off, leave the collision volumes there.
5) All the interactivity happens by colliding gaze with collision volumes.  Button-moving has nothing to do with it ....
6) Although, it might be nice if you could see holographic switches move, but none of this free-floating stuff.  The holo-switch would move (toggle flips, sliders slides) and you "chase it" with the physical switches.

See my backlog list on my Trello.  Also, would like to transition to Submarine and Aircraft projects.

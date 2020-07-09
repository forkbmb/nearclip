# NearClip

Some users with small avatars are experiencing issues with clipping in worlds that are not set up correctly; they may be cut in half by the camera's near clipping plane. Here's my humble attempt at resolving this. 

This simple mod sets the `near` value of the player's camera's clippingPlane to the smallest possible value every second for 30 seconds after a new level has loaded. This is a hacky solution to the problem that we can't know exactly when the world's `referenceCamera`'s settings are copied onto the player's camera. If we overwrite too early, the bad `referenceCamera` settings will overwrite our change; if we overwrite too late, players will experience the problem temporarily. So far, I have not had any reports of this trivial solution breaking anything.

The method of finding the player's camera has been provided by (Hector Panzer)² of the [VRChat Modding Group Discord](https://discord.gg/rCqKSvR)

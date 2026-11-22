# FPS Labyrinth Game

A first-person 3D labyrinth game. Explore dark corridors with a flashlight, solve a pressure plate puzzle to open a door, and find the glowing sphere to finish each level. The second level raises the difficulty by turning the inner walls almost invisible.

## Gameplay Video

https://github.com/user-attachments/assets/536ec428-7b54-47dc-8572-a311835a2657

## Features

- **First-person controller** – Walk, jump and look around with keyboard and mouse
- **Player flashlight** – Spot light attached to the camera to explore dark corridors
- **Pressure plate puzzle** – Stand on the plate to lift the door, step off and it slowly closes
- **Moving door** – Smooth kinematic movement with `Vector3.MoveTowards`
- **Collectible goal** – Touch the finish sphere to complete the level
- **Two levels** – The second level uses nearly invisible inner walls for extra difficulty
- **Scene management** – Levels are loaded with Unity's `SceneManager`
- **Standalone build** – The game can be exported as a PC executable

## Controls

| Input     | Action        |
|-----------|---------------|
| W A S D   | Move          |
| Space     | Jump          |
| Mouse     | Look around   |

## Credits

The first-person controller comes from Unity's Standard Assets package. All rights to those assets belong to Unity Technologies.

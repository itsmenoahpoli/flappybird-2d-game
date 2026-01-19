# Scene Setup

## Game Scene

1. Create a new scene and name it `Game`.
2. **Bird (Player):**
   - Create a 2D Sprite for the Bird.
   - Add a `Rigidbody2D` component (set `Gravity Scale` to 1.5).
   - Add a `CircleCollider2D` or `BoxCollider2D`.
   - Attach the `Bird.cs` script.
   - Set the `Tag` to `Player`.
3. **Pipes (Prefab):**
   - Create a parent empty GameObject for the Pipes.
   - Add two pipe sprites (top and bottom) with `BoxCollider2D`.
   - Add an empty GameObject in the middle with a `BoxCollider2D` (set to `Is Trigger`) and attach the `ScoreTrigger.cs` script.
   - Attach the `Pipe.cs` script to the parent GameObject.
   - Drag this GameObject into the `Assets/Prefabs` folder to create a prefab, then delete it from the scene.
4. **Pipe Spawner:**
   - Create an empty GameObject named `PipeSpawner`.
   - Attach the `PipeSpawner.cs` script.
   - Assign the Pipe prefab to the `Pipe Prefab` field.
5. **Game Manager:**
   - Create an empty GameObject named `GameManager`.
   - Attach the `GameManager.cs` script.
   - Create a UI Canvas with a Text element for the score and a "Game Over" panel with a Restart button.
   - Assign the UI elements to the fields in the `GameManager` script.

## Main Menu Scene

1. Create a new scene and name it `Menu`.
2. Create a UI Canvas with "Play" and "Quit" buttons.
3. Attach the `MainMenu.cs` script to an empty GameObject.
4. Link the button `OnClick()` events to the `PlayGame()` and `QuitGame()` methods.

---
[Back to README](../README.md)

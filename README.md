[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects
- UI
    - Text
        - Seeds planted ui
        - Seeds in inventory/remaining ui
    - Attributes
        - increment/decrement based on player input
        - Seeds planted goes up when player presses space bar and inventory goes down
        - Stops updating when player has placed all seeds available to them  
- Player
    - Bunny sprite
    - Movement
        - WASD keys
            - Up, Left, Down, Up 
        - Speed 
            -  Slow
    - Ability to plant plants(space bar)
        - Only has 5 seeds
- Plants
    - spawn/instantiate at player’s position
    - Sprite
    - Only 5 can exist

## Devlog
What I wrote down originally was very bare bones compared to Professor Reid's plan. I only had the objects that I saw. I added a few things to mine in class but it still needed more work. I first updated my plan to have more detail before I started coding so that I could follow it as a guide. After finishing with my code, I noticed that my UI plan takes more of the logic for the counters _numSeedPlanted and _numSeedLeft. The player object in code is somewhat similar to the plan, I was missing references to the UI and Plant game objects(the PlantCountUI and plant prefab). It has a speed component(_speed), ability(this would be the method PlantSeed), and an amount of seeds(_numSeeds) allowed just like in the code. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

## Prof comments
It's fine if your plans end up different than mine, but I'm glad that you added more details after seeing the activity answers! Specificity is really important when we're planning how we're going to engineer a game. This Devlog will get full credit, but it is a little short, and I would have liked you to elaborate more on the problem you encountered where you were missing references to the UI and Plant GameObjects- what was supposed to have a reference that was missing, and how did you fix it? Making sure to go into detail on something like that will ensure you'll earn full credit in the future.

Please consider formatting your break-down activities with the hyphen '-' symbol as suggested above, and remove the prompts. This will make it a lot easier for me to read. See the [README formatting guide here](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax).

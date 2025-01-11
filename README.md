[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/MjLLqDcN)
# HW1
## W1L2 In-Class Activity
Objects
    UI
        Text
            Seeds planted ui
            Seeds in inventory/remaining ui

        Attributes
            increment/decrement based on player input
                Seeds planted goes up when player presses space bar and inventory goes down

            Stops updating when player has placed all seeds available to them  

    Player
        Bunny sprite
        Movement
            WASD keys
                Up, Left, Down, Up 

            Speed 
                Slow

        Ability to plant plants(space bar)
            Only has 5 seeds
    Plants
        spawn/instantiate at player’s position
        Sprite
        Only 5 can exist

Put your notes from the W1L2 (Thurs, Jan 9) in-class activity here.

## Devlog
Prompt: Include the HW1 break-down exercise you wrote during the Week 1 - Lecture 2 (Jan 9) in-class activity (above). If you did not attend and perform this activity, review the lecture slides and write your own plan for how you believe HW1 should be built. If your initially proposed plan turned out significantly different than the activity answers given by Prof Reid, you may want to note what was different. Then, write about how the plan you wrote in the break-down connects to the code you wrote. Cite specific class names and method names in the code and GameObjects in your Unity Scene.


Write your Devlog here!
What I wrote down originally was very bare bones compared to Professor Reid's plan. I only had the objects that I saw. I added a few things to mine in class but it still needed more work. I first updated my plan to have more detail before I started coding so that I could follow it as a guide. After finishing with my code, I noticed that my UI plan takes more of the logic for the counters _numSeedPlanted and _numSeedLeft. The player object in code is somewhat similar to the plan, I was missing references to the UI and Plant game objects(the PlantCountUI and plant prefab). It has a speed component(_speed), ability(this would be the method PlantSeed), and an amount of seeds(_numSeeds) allowed just like in the code. 

## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - character and item sprites

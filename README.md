[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/7qg5CCgx)
# HW2
## Devlog
The first part of my MG2 break-down activity is the floor. 
In my floor plan, the only component I had was a collision factor that interacts with the player collision which was implemented in my ground gameobject. 
To connect to that, the player’s collision also made it so that when the player was off of the ground that there was a isGrounded boolean that became false and reset to true when the player was on the ground through the tags. 
The player had a Rigidbody set to Dynamic to simulate gravity and called on that to provide vertical movement using the velocity and x axis which was then multiplied by the player’s jump height integer. 
The vertical jump had an if statement to ensure that the player needed to have isGrounded and the GetKeyPressed as Space. 
The player collision is also connected to the coin manager script by calling the AddCoin method when interacting with the coin tag in the coin prefabs and destroys the coins colliding. 
From there, the coin breakdown got split in my code into the coins and the coin manager. 
The actual coin script connected to the prefab with the speed, a collider, a left moving transform.Translate multiplied by the speed and time, and an if statement that destroyed any coins that went past x=-10. 
This took the horizontal movement, coin speed, collision, and prefab parts of my break-down. 
My coin manager connected to the UI, became a spawn point, and spawned the coins. 
The coin manager at Start sets the coin count to 0 and calls the SpawnTimer method. 
The SpawnTimer method creates a timer variable and sets it to a random number between 0.2 and 1.5 using Random.Range. 
The Update makes sure that the spawnTimer variable goes down with the Unity time as well as makes sure that if the spawnTimer variable is greater than the timer variable so that the CreateCoin method can be called, the spawnTimer variable can be set to 0, and the SpawnTimer method can be called once again to make sure it goes infinitely. 
The Create Coin method Instanciates the coin prefab and sets the position to the Transform spawnpoint position and uses Quaternion.identity to set rotation to nothing. 
Another method created in the manager is AddCoin which increases the coins variable by one and updates the UI using the UpdateCoins method when called. 
The Coin Manager script is connected to an empty CoinManage gameobject that sets the coin spawn point to itself and spawns the actual coins. 
The CoinUI script contains the TMP_Text for the coin counter to update and the UpdateCoins method sets the _coinText to a string and replaces the previous text. 
The big differences between my break-down and actual scripts are the UI functions because the UI neither deletes the coins nor increases the counter and instead just updates the text and the coin breakdown gets split between the manager and actual coins. 


## Open-Source Assets
If you added any other outside assets, list them here!
- [Sprout Lands sprite asset pack](https://cupnooble.itch.io/sprout-lands-asset-pack) - rabbit and item sprites
- [Pixel Penguin 32x32 Asset pack](https://legends-games.itch.io/pixel-penguin-32x32-asset-pack) - penguin sprites
- [Coins 2D](https://artist2d3d.itch.io/2d) - coin sprites
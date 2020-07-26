
challange's 1 to 5 are in the TopDown project in scenes
the tank game is in the TopDown project in the "TanksButNoTanks" scene

Game Development 2.2 TopDown Report

From challange one to five ive been working on a topdown shooter where every kill counts. Dodging enemy bullets, running away form chasing, patroling and predicting enemies as well as picking up health, keys and slowing down time, lot of elements learned throughout the year have been utilised well to make a little game that I am proud of.

objective:
kill all of the npc's in the level to move on to the next one.
5 bullets in a mag
reload quick or die
slow down time
refill health the keep the clowns away

Gameplay:
within the game there are 4 types of enemies. the clowns only follow when you are at half health, the purple balls spin with blades when damaged, the red shooter follows at a certain distance and will stop a certain distance away to allow it to shoot and the petroling enemy walkes a path until the player is within a range before it chases and shoots.
keys allow you to open locked doors
health increases your health by 1
the clocks slow down time for a limited time allowing you to dodge enemy bullets or increase accurecy


Pattern Movement:
Within the game there is a patroling enemy. This enemy has the same abilities as the shooting enemy except this enemy when not within the range of the enemy, will walk a designated path. This path can be edited whatever way is best for the level design.
![alt text](https://github.com/aitsoftwaredesign/gd22-lorcanturner/blob/master/Images/Screenshot%20(12).png)

Finite State Machines :
finite state machines are a great way of giving you character multible states of being in a way thats easy to read, code and manipulte. fsm is a code configuration using a switch statement. states can change under spacific cercumstances. ie. if distance is < 4 change the state to chase.
![alt text](https://github.com/aitsoftwaredesign/gd22-lorcanturner/blob/master/Images/Screenshot%20(8).png)

line of sight chasing:
we did this in multiple ways. in the basic chase we simply said if your less than the x position increase, if your greater than x position, decrease. The same was done for the y axis. this works but has a few flaws such as jittering and moving indirectly. I kept this chase for the basic enemy to allow for movement variation in my game between enemies. For the rest of the enemies the "moveTowards" function was used. This is an inbuilt funcion that allows for a smooth movement from one position to another.
![alt text](https://github.com/aitsoftwaredesign/gd22-lorcanturner/blob/master/Images/Screenshot%20(9).png)

Vector Math :
Vector math was used in this project for calculating and transforming positions and rotations of npc's in ralation to themselves and the playercharacter. For instance the shooting enemy when he is out of range is stationary, but when the player is within range the shooting enemy rotates towards the enemy to shoot towards and transforms its position to a place closer the the player.


Interception: 
Within our project we were set the challange to use vectors the predict where the player character is going  so the enemy can intersect the players path. this was done by using the velocity of the player to determine the normilized vector for the enemy to follow.

 

​🏀 2D Ball Jump: Obstacle Survival
​A fast-paced 2D Physics-based game developed in Unity. The core mechanic involves controlling a ball to jump over obstacles while maintaining momentum. One wrong move or a single collision with an obstacle ends the game!
​✨ Key Features
​Physics-Based Movement: Utilizes Rigidbody2D and AddForce for realistic jumping mechanics.
​Precision Gameplay: Success depends on the timing of each jump to clear various obstacles.
​Instant Collision Detection: Integrated OnCollisionEnter2D logic that triggers a "Game Over" state immediately upon hitting an obstacle.
​Dynamic Obstacle System: Obstacles are designed to challenge the player's reaction speed.
​🛠 Technical Stack
​Game Engine: Unity 2022+
​Language: C#
​Physics: Unity Physics 2D (Rigidbodies, Colliders, and Triggers)
​UI System: Unity Canvas for Score and Game Over screens.
​📁 Project Structure
​BallJump.cs – Handles the jumping force and user input (Space/Tap).
​ObstacleController.cs – Manages the movement and spawning of obstacles.
​CollisionHandler.cs – Detects contact with obstacles and manages scene reloading or game-over logic.
​ScoreManager.cs – Tracks the number of successfully cleared obstacles.
​🎮 How to Play
​Start: Press the Spacebar or Tap the screen to make the ball jump.
​Objective: Jump over the obstacles moving toward you.
​Lose Condition: If the ball touches any part of an obstacle, the game is over.
​Goal: Achieve the highest score by surviving as long as possible!
​Developed by: [Rukhshona Akhmedova]
Project Goal: To master 2D collision logic, physics interactions, and game state management in Unity.

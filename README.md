# My First Unity Game Project
Welcome to my first Unity game project! This project is a simple menu scene with two buttons, created as an introductory exercise to learn the basics of Unity game development.

## Project Overview
This project features:

* A main menu with a "Play" button and a "Trophy" button.
* Basic UI setup using Unity's Canvas and UI elements.
* Basic script interactions to handle button events.

## Issues and Fixes
### Restarting Issues
When restarting the game, I encountered a few errors:

`MissingReferenceException: The object of type 'UnityEngine.Transform' has been destroyed but you are still trying to access it.`

### Temporary Workaround
To ensure the game runs smoothly for now, I had to temporarily disable the DataManager script. This script was causing issues during the game restart, and further debugging is required to identify the root cause of these errors.

If you want to run the project without errors, please make sure the DataManager script is disabled in the Inspector window.

## How to Run
1. Open the project in Unity.
2. Ensure that the DataManager GameObject and its script are disabled.
3. Play the scene to see the menu and interact with the buttons.

## Project Structure
The project includes the following important folders:
* **Assets**: Contains all the game assets, including scenes, scripts, and UI elements.
* **Packages**: Contains the project’s dependencies and package configurations.
* **ProjectSettings**: Contains project-specific settings like input configurations, quality settings, and other settings essential for the project.

## Future Improvements
* Debug and fix the issues related to the DataManager script.
* Add more interactive elements and functionalities.
* Improve UI/UX for a better user experience.

## Screenshots

## Screenshots

<img src="./Screenshots/Screenshot%20from%202025-01-23%2011-18-58.png" alt="In Game" width="55%" style="display:inline-block; margin-right:10px;">
<img src="./Screenshots/Screenshot%20from%202025-01-23%2011-19-45.png" alt="In Game" width="55%" style="display:inline-block; margin-right:10px;">
<img src="./Screenshots/Screenshot%20from%202025-01-23%2012-31-53.png" alt="In Game 1" width="55%" style="display:inline-block; margin-right:10px;">
<img src="./Screenshots/Screenshot%20from%202025-01-23%2012-31-07.png" alt="In Game 2" width="55%" style="display:inline-block; margin-right:10px;">
<img src="./Screenshots/Screenshot%20from%202025-01-23%2012-30-31.png" alt="In Game 3" width="55%" style="display:inline-block; margin-right:10px;">
<img src="./Screenshots/Screenshot%20from%202025-01-23%2012-25-59.png" alt="In Game 4" width="55%" style="display:inline-block;">



## Feedback and Contributions
As this is my first Unity project, any feedback and suggestions for improvements are highly welcome. Feel free to fork the repository and submit pull requests with enhancements.

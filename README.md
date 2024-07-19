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

## Future Improvements
* Debug and fix the issues related to the DataManager script.
* Add more interactive elements and functionalities.
* Improve UI/UX for a better user experience.

## Screenshots

## Feedback and Contributions
As this is my first Unity project, any feedback and suggestions for improvements are highly welcome. Feel free to fork the repository and submit pull requests with enhancements.


using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour 
{

	void OnGUI()
	{
		const int buttonWidth = 90;
		const int buttonHeight = 50;
		
		// Placing button's on the screen
		Rect buttonSingle = new Rect(Screen.width / 2 - (buttonWidth / 2),(Screen.height / 3) ,buttonWidth,buttonHeight);
		Rect buttonMulti = new Rect(Screen.width / 2 - (buttonWidth / 2),(Screen.height / 3) + 60 ,buttonWidth,buttonHeight);
		Rect buttonExit = new Rect(Screen.width / 2 - (buttonWidth / 2),(Screen.height / 3) + 120 ,buttonWidth,buttonHeight);
		
		// draws button on scrren with the following text
		if(GUI.Button(buttonSingle,"Single-player"))
		{
			//if the button is clicked, singleplayer scene is loaded
			Application.LoadLevel("singleplayer");
		}

		// Draw a button to start the game
		if(GUI.Button(buttonMulti,"Multi-player"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.LoadLevel("multiplayer");

		}

		// Draw a button to start the game
		if(GUI.Button(buttonExit,"Quit"))
		{
			// On Click, load the first level.
			// "Stage1" is the name of the first scene we created.
			Application.Quit();
		}
	}
	
}

using UnityEngine;
using System.Collections;

public class PausMenu : MonoBehaviour {

	bool pauseMenu;

	void Update() 
	{
		if(Input.GetButtonDown("PauseMenu")) 
		{

			pauseMenu = !pauseMenu;
		}
		
	}

	void OnGUI() 
	{
		var centeredStyle = GUI.skin.GetStyle("Box");
		centeredStyle.alignment = TextAnchor.UpperCenter;
		if (pauseMenu) 
		{
			GUI.Box (new Rect (Screen.width / 2 - 75, Screen.height / 2 - 25, 150, 150), "Menu", centeredStyle);


			if (GUI.Button (new Rect (Screen.width / 2 - 50 + 10 , Screen.height / 2 + 40, 80, 20), "Level 1")) {
				Application.LoadLevel (1);
			}
			if (GUI.Button (new Rect (Screen.width / 2 - 50 + 10 , Screen.height / 2 + 70, 80, 20), "Exit Game")) {
				Application.Quit();
			}
		}


	}


}

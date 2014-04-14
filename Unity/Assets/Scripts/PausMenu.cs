using UnityEngine;
using System.Collections;

public class PausMenu : MonoBehaviour {



		void OnGUI() {
		var SwitchOn = false;
			if(Input.GetKey(KeyCode.Escape)) {

				SwitchOn = true;
				//Make a background box
				if(SwitchOn.Equals(true)) {
					GUI.Box(new Rect(10,10,100,90),"Menu");
				
					//Make the first button. If its is pressed, Application.Loadlevel(1) will be executed
					if(GUI.Button(new Rect(20,40,80,20), "Pause")) {

					}

					//Make the second button
					if(GUI.Button (new Rect(20,70,80,20), "Level 1")) {
						Application.LoadLevel(1);
					}
				}
			}
		}

}
	
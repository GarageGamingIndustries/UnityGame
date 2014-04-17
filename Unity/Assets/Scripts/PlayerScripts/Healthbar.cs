using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {
	
	GUIStyle style = new GUIStyle();
	GUIStyle bkgroundstyle = new GUIStyle();
	Texture2D texture;
	Texture2D background;
	Color redColor = Color.red;
	Color greenColor = Color.green;
	Color grayColor = Color.gray;


	
	void Start()
	{
		texture = new Texture2D(1, 1);
		texture.SetPixel(1, 1, greenColor);
		background = new Texture2D(1,1);
		texture.SetPixel (1,1,grayColor);
	}
	
	private void Update()
	{
		
		if (PlayerHealth.actualHealth >= 80f)
		{
			texture.SetPixel(1, 1, greenColor);
		}

		if (PlayerHealth.actualHealth <= 20f)
		{
			texture.SetPixel(1, 1, redColor);
		}

	}
	
	public void OnGUI()
	{	
		
		texture.Apply();

		style.normal.background = texture;
		bkgroundstyle.normal.background = background;
		GUI.Box(new Rect(0,0,210,40),new GUIContent(""));
		GUI.Box (new Rect(5,5,200,30), new GUIContent(""),bkgroundstyle);
		if(PlayerHealth.actualHealth > 0){
			GUI.Box(new Rect(5, 5, (PlayerHealth.actualHealth/PlayerHealth.maxHealth*200), 30), new GUIContent(" " + PlayerHealth.actualHealth + " / " + PlayerHealth.maxHealth), style);}
		else{ 
				GUI.Box(new Rect(5, 5, (PlayerHealth.actualHealth/PlayerHealth.maxHealth*200), 30), new GUIContent(" " + PlayerHealth.actualHealth + " / " + PlayerHealth.maxHealth + " - You are Dead!"), style);}
	}
}
using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {
	
	GUIStyle style = new GUIStyle();
	Texture2D texture;
	Color redColor = Color.red;
	Color greenColor = Color.green;
	//GameObject buddy = GameObject.Find ("Player");
	//PlayerHealth p = buddy.GetComponent<PlayerHealth> ();
	PlayerHealth p = new PlayerHealth();

	
	void Start()
	{
		//GameObject Player = GameObject.Find ("Player");
		//PlayerHealth p = Player.GetComponent <PlayerHealth> ();

		texture = new Texture2D(1, 1);
		texture.SetPixel(1, 1, greenColor);
	}
	
	private void Update()
	{
		
		if (p.health > 50)
		{
			texture.SetPixel(1, 1, greenColor);
		}

		if (p.health < 50)
		{
			texture.SetPixel(1, 1, redColor);
		}

	}
	
	public void OnGUI()
	{	
		
		texture.Apply();
		
		style.normal.background = texture;
		GUI.Box(new Rect(0, 0, (p.health*3), 50), new GUIContent(""), style);
	}
}
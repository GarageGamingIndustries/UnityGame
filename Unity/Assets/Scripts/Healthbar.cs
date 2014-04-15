using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {
	
	GUIStyle style = new GUIStyle();
	Texture2D texture;
	Color redColor = Color.red;
	Color greenColor = Color.green;

	public PlayerHealth script;

	
	void Start()
	{
		//GameObject Player = GameObject.Find ("Player");
		//PlayerHealth p = Player.GetComponent <PlayerHealth> ();
		script = GetComponent<PlayerHealth>();
		texture = new Texture2D(1, 1);
		texture.SetPixel(1, 1, greenColor);
	}
	
	private void Update()
	{
		
		if (script.getHp() > 50)
		{
			texture.SetPixel(1, 1, greenColor);
		}

		if (script.getHp() < 50)
		{
			texture.SetPixel(1, 1, redColor);
		}

	}
	
	public void OnGUI()
	{	
		
		texture.Apply();
		
		style.normal.background = texture;
		GUI.Box(new Rect(0, 0, (script.getHp()*3), 50), new GUIContent(""), style);
	}
}
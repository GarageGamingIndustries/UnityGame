using UnityEngine;
using System.Collections;

public class Healthbar : MonoBehaviour {
	
	GUIStyle style = new GUIStyle();
	Texture2D texture;
	Color redColor = Color.red;
	Color greenColor = Color.green;


	
	void Start()
	{
		texture = new Texture2D(1, 1);
		texture.SetPixel(1, 1, greenColor);
	}
	
	private void Update()
	{
		
		if (PlayerHealth.actualHealth >= 50f)
		{
			texture.SetPixel(1, 1, greenColor);
		}

		if (PlayerHealth.actualHealth <= 50f)
		{
			texture.SetPixel(1, 1, redColor);
		}

	}
	
	public void OnGUI()
	{	
		
		texture.Apply();
		
		style.normal.background = texture;
		GUI.Box(new Rect(0, 0, (PlayerHealth.actualHealth*3), 50), new GUIContent(""), style);
	}
}
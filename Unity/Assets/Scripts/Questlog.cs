using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Questlog : MonoBehaviour {
	public int slotsNo;
	public int questsNo;
	public List<Quest> questLog = new List<Quest>();
	public List<Quest> slots = new List<Quest>();	
	private QuestDatabase questDatabase;
	private bool showQuestLog;
	// Use this for initialization
	void Start () 
	{
		for(int i = 0; i < slotsNo; i++) 
		{
			slots.Add (new Quest());
			questLog.Add(new Quest());
		}
		questDatabase = GameObject.FindGameObjectWithTag("Quest Database").GetComponent<QuestDatabase>();
		AddQuest (0);
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Input.GetButtonDown("QuestLog")) 
		{
			showQuestLog = !showQuestLog;
		}

	}

	void OnGUI()
	{
		if(showQuestLog)
		{
			var centeredStyle = GUI.skin.GetStyle("Box");
			centeredStyle.alignment = TextAnchor.UpperCenter;
			GUI.Box(new Rect(150,70,200,20), "asd" + questLog[0].questName);
			GUI.Box(new Rect(150, 50, 200,100),"Questlog");
			GUI.Box(new Rect(150, 150, 200,300),"");
			GUI.Label( new Rect( 150, 150, 200, 280 ), " sfbkjldsfkjlasdklfdblkjadsf vlkdfbkl " +
				"\n sdgfghsdfasdsdfdffglkjl werfpiodgpodfob a skjdsdföbkj fdbkj sfdjk sd fbkjl " +
				"wer jsfgpodgöpnkbvsd kjsaf lköjsbölkjfgbökljsafd öjkd bkjdfg lkö");
			if(GUI.Button(new Rect(270,430,80,20),"Delete"))
			{
			
			}
			if(GUI.Button(new Rect(150,430,80,20),"Read"))
			{
			
			}
		}
	}
	void AddQuest(int id)
	{
		for (int i = 0; i < questLog.Count; i++) 
		{
			if (questLog[i].questName == null) 
			
				
				for(int j = 0; j < questDatabase.quests.Count; j++)
				{
					if(questDatabase.quests[j].questID == id) 
					{
						questLog[i] = questDatabase.quests[j];
					}
				}
				break;
			}
	}
		

}

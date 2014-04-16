using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class QuestDatabase : MonoBehaviour {
	public List<Quest> quests = new List<Quest>();
	// Use this for initialization
	void Start()
	{
		quests.Add (new Quest("Raging Fire", 0, "Go to the Cave of Fire and kill all Raging Fires!", Quest.QuestType.Solo)); 
	}

}

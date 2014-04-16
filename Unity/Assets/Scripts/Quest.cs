using UnityEngine;
using System.Collections;

[System.Serializable]
public class Quest {

	public string questName;
	public int questID;
	public string questDesc;
	public QuestType questType;

	public enum QuestType 
	{
		Solo,
		Group
	}

	public Quest(string name, int id, string desc, QuestType type)
	{
		questName = name;
		questID = id;
		questDesc = desc;
		questType = type;
	}
	public Quest()
	{


	}
	


}

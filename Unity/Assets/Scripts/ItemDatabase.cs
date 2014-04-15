using UnityEngine;
using System.Collections;
using System.Collections.Generic;
public class ItemDatabase : MonoBehaviour {
	public List<Item> items = new List<Item>();

	void Start()
	{
		items.Add(new Item("Sword",0,"A Sword",2,1, Item.ItemType.Weapon));
		items.Add(new Item("Potion",1,"A yummy potion",0,0, Item.ItemType.Consumable));
	}
}

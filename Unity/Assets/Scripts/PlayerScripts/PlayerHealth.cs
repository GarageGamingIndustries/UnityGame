﻿using UnityEngine;
using System.Collections;

public class PlayerHealth : MonoBehaviour {

	public static float actualHealth = 100f;
	public static float maxHealth = 100f;
	//public AudioClip deathClip;
	private bool playerDead;

	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		TakeDamage (0.1f);
		if (actualHealth <= 0f) 
		{
			if(!playerDead)
			{
				PlayerDying();
			}else
			{
				PlayerDead();
			}
		}
	}

	void PlayerDying()
	{
		playerDead = true;
	}
	void PlayerDead()
	{
		// playerMovement.enabled = false;
	}

	public void TakeDamage(float amount)
	{
		actualHealth -= amount;
	}
}

using UnityEngine;
using System.Collections;

public class EnemyHealth : MonoBehaviour {

	public static float actualHealth = 100f;
	public static float maxHealth = 100f;

	private bool enemyDead;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (actualHealth <= 0f) 
		{
			if(!enemyDead)
			{
				EnemyDying();
			}else
			{
				EnemyDead();
			}
		}
	}

	void EnemyDying()
	{
		enemyDead = true;
	}
	void EnemyDead()
	{
		// playerMovement.enabled = false;
	}
	
	public void TakeDamage(float amount)
	{
		actualHealth -= amount;
	}
}

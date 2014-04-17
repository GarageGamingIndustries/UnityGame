using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour {
	
	public GameObject target;
	public float attackTimer;
	public float coolDown;
	public float EnemyDamage;
	public float CritChance;
	public float CritDmg;
	
	// Use this for initialization
	void Start () {
		attackTimer = 0;
		//Original cooldown = 2.0f
		coolDown = 0.5f;
		EnemyDamage = 10;
		CritChance = 10f; // 10% - should be calculated later based on level difference
		CritDmg =1.2f; //120% Dmg;
	}
	
	// Update is called once per frame
	void Update () {
		if(attackTimer > 0)
			attackTimer -= Time.deltaTime;
		if (attackTimer < 0)
			attackTimer = 0;
		if(attackTimer == 0){
			Attack();
			attackTimer = coolDown;
		}
	}
	
	private void Attack(){
		float distance = Vector3.Distance (target.transform.position, transform.position);
		
		Vector3 dir = (target.transform.position - transform.position).normalized;
		float direction = Vector3.Dot (dir, transform.forward);
		
		Debug.Log (direction);
		
		if(distance < 1.7){
			if(direction > 0){
				//Attacks only when alive - Stops if dead
				if(PlayerHealth.actualHealth >0f){
					float crit = Random.Range (0,100);
					if(crit > CritChance){
						PlayerHealth.actualHealth -= EnemyDamage;
					}
					else {
						PlayerHealth.actualHealth -= EnemyDamage * CritDmg;
					}
				}
			}
		}
	}
}

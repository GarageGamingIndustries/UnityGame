using UnityEngine;
using System.Collections;

public class PlayerSkills : MonoBehaviour {

	public int SkillAttack, SkillWalk, SkillJump = 1;  //these are the skills
	public int Iterator, IteratorMAX; // how long it takes to gain a skill point

	// Use this for initialization
	void Start () {
		IteratorMAX = 10;
	}
	
	// Update is called once per frame
	void Update () {
		Interaction ();
	}

	void Interaction()
	{
				if (Input.GetButtonUp ("Fire1")) {
						Iterator++;
						Skillcalc (1);
				}
				if (Input.GetKeyDown(KeyCode.W)) {
						Iterator++;
						Skillcalc (2);
				}
				if (Input.GetKeyDown(KeyCode.Space)) {
						Iterator++;
						Skillcalc (3);
				}
	}
	void Skillcalc(int Skill)
	{
				switch (Skill) {
				case 1: 
						if (Iterator >= IteratorMAX) {
								Iterator = 0;
								SkillAttack++;
						}
						break;
				case 2: 
						if (Iterator >= IteratorMAX) {
								Iterator = 0;
								SkillWalk++;
						}
						break;
				case 3: 
						if (Iterator >= IteratorMAX) {
								Iterator = 0;
								SkillJump++;
						}
						break;
					}
			}
	}

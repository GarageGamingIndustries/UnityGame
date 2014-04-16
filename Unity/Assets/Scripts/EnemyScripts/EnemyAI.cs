using UnityEngine;
using System.Collections;

public class EnemyAI : MonoBehaviour {

    public Transform target;
    public int moveSpeed;
    public int rotationSpeed;
	public float maxDistance;
	public bool isFollowing, isPulled;

    private Transform myTransform;

    void Awake()
    {
        myTransform = transform;
    }

	// Use this for initialization
	void Start () 
    {
        GameObject gO = GameObject.FindGameObjectWithTag("Player");
        target = gO.transform;
		maxDistance = 1.5f;
		isFollowing = false;
		isPulled = false;
	}
	
	// Update is called once per frame
	void Update ()
    {
		Debug.DrawLine(target.position, myTransform.position, Color.yellow);

		float distance = Vector3.Distance (target.position, myTransform.position);
		Debug.Log (distance);

		float pullDistance = Vector3.Distance (target.transform.position, transform.position);
		if (pullDistance < 10) {
			isPulled = true;
		}

		if (isFollowing == true && distance > 50) {
			isFollowing = false;
			isPulled = false;
		}
		else
		{
			if (distance > maxDistance && isPulled == true ) {
				isFollowing = true;

				// Look at target
				myTransform.rotation = Quaternion.Slerp (myTransform.rotation, Quaternion.LookRotation (target.position - myTransform.position), rotationSpeed * Time.deltaTime);

				// Move towards target
				myTransform.position += myTransform.forward * moveSpeed * Time.deltaTime;
			}
		}
	}
}

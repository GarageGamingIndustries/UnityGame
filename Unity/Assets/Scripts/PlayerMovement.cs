using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	public float turnSmoothing = 15f;
	public float speedDampTime = 0.1f;
	

	// Use this for initialization
	void Start () {
	
	}

	void FixedUpdate()
	{
		// Cache the inputs
		float h = Input.GetAxis ("Horizontal");
		float v = Input.GetAxis ("Vertical");

		MovementManagement (h, v);
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void MovementManagement( float horizontal, float vertical)
	{
		if (horizontal != 0f || vertical != 0f) 
		{
			Rotating(horizontal,vertical);
		}
	}

	void Rotating ( float horizontal, float vertical)
	{
		Vector3 targetDirection = new Vector3 (horizontal, 0f, vertical);

		Quaternion targetRotation = Quaternion.LookRotation(targetDirection, Vector3.up);
		
		Quaternion newRotation = Quaternion.Lerp(rigidbody.rotation, targetRotation, turnSmoothing * Time.deltaTime);
	}
}

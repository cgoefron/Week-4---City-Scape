using UnityEngine;
using System.Collections;

public class PlayerMovement1 : MonoBehaviour {

	private float speed = 1.0f;
	private Vector3 moveDirection;


	// Use this for initialization
	void Start () {
	
	}
	
	void Update()
	{

	
		//Player One Arrow Keys
		if(Input.GetKey(KeyCode.RightArrow))
		{
			transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
			//moveDirection = new Vector3(10,0,0);

		}
		if(Input.GetKey(KeyCode.LeftArrow))
		{
			transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
			//moveDirection = new Vector3(-10,0,0);

		}
		if(Input.GetKey(KeyCode.DownArrow))
		{
			//transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
			transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
			//moveDirection = new Vector3(0,0,10);
		}
		if(Input.GetKey(KeyCode.UpArrow))
		{
			//transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
			transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
			//moveDirection = new Vector3(0,0,-10);
		}

		//Quaternion wanted_rotation = Quaternion.LookRotation(moveDirection);
		//transform.rotation = Quaternion.RotateTowards(transform.rotation, wanted_rotation, speed * 10 * Time.deltaTime);
	}
	
}



using UnityEngine;
using System.Collections;

public class PlayerMovement2 : MonoBehaviour {
	
	private float speed = 1.0f;
	private Vector3 moveDirection;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	void Update()
	{

		//Player TWO WASD
		if(Input.GetKey(KeyCode.D))
		{
			//transform.Translate(new Vector3(speed * Time.deltaTime,0,0));
			moveDirection = new Vector3(10,0,0);
			//transform.Rotate = new Vector3(5,0,0);
		}
		if(Input.GetKey(KeyCode.A))
		{
			//transform.Translate(new Vector3(-speed * Time.deltaTime,0,0));
			moveDirection = new Vector3(-10,0,0);
		}
		if(Input.GetKey(KeyCode.S))
		{
			//transform.Translate(new Vector3(0,-speed * Time.deltaTime,0));
			transform.Translate(new Vector3(0,0,-speed * Time.deltaTime));
			//moveDirection = new Vector3(0,0,10);
		}
		if(Input.GetKey(KeyCode.W))
		{
			//transform.Translate(new Vector3(0,speed * Time.deltaTime,0));
			transform.Translate(new Vector3(0,0,speed * Time.deltaTime));
			//moveDirection = new Vector3(0,0,-10);
		}
		
		Quaternion wanted_rotation = Quaternion.LookRotation(moveDirection);
		transform.rotation = Quaternion.RotateTowards(transform.rotation, wanted_rotation, speed * 20 * Time.deltaTime);
	}
	
}
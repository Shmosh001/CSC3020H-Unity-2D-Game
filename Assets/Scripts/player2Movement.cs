using UnityEngine;
using System.Collections;

public class player2Movement : MonoBehaviour {

	public float speed;
	
	// Update is called once per frame
	void FixedUpdate () {
		
		
		if (Input.GetKey ("w")) //up key moves player in the y direction
		{
			//transform.Translate(0,speed * Time.deltaTime,0);
			rigidbody2D.AddForce (gameObject.transform.up * speed); 
		}
		
		if(Input.GetKey("a"))//Press left arrow key to rotate anticlockwise on the Z AXIS
		{
			transform.Rotate(0,0,4); //rotate anticlockwise
			rigidbody2D.angularVelocity = 0; //prevents player rotating without any keys being pressed after collision
		}
		if(Input.GetKey("d"))//Press right arrow key to rotate clockwise on the Z AXIS
		{
			transform.Rotate(0,0,-4); //rotate clockwise
			rigidbody2D.angularVelocity = 0; //prevents player rotating without any keys being pressed after collision
		}
		
	}
}

﻿using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

	public float speed;
	public Transform player1;
	public Transform player2;
	private float angle;
	private Vector3 direction1;
	private Vector3 direction2;


	
	// Update is called once per frame
	void Update () 
	{
		direction1 = player1.position - transform.position; //vector between player1 and enemy. Has direction.
		direction2 = player2.position - transform.position; //vector between player2 and enemy. Has direction.

		if (direction1.magnitude < direction2.magnitude) 
		{
			 angle = Mathf.Atan2 (direction1.y, direction1.x) * Mathf.Rad2Deg - 90; //sets angle that enemy needs to rotate to face the target
		} 
		else 
		{
			angle = Mathf.Atan2 (direction2.y, direction2.x) * Mathf.Rad2Deg - 90; //sets angle that enemy needs to rotate to face the target
		}

		transform.eulerAngles = new Vector3 (0, 0, angle); //sets enemy line of sight by setting enemy rotation on z axis
		rigidbody2D.AddForce (gameObject.transform.up * speed); //moves object forward

	}
}

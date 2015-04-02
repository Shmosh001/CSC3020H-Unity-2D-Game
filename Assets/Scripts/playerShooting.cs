using UnityEngine;
using System.Collections;

public class playerShooting : MonoBehaviour {

	public float speed;
	public Rigidbody2D laserPrefab;
	//public Transform player1;
	

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (Input.GetKey ("x")) 
		{
			Rigidbody2D laser = Instantiate(laserPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), Quaternion.identity) as Rigidbody2D;

			laser.rigidbody2D.AddForce(transform.up * speed);


		}
	}
}

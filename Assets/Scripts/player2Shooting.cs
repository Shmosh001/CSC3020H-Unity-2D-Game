using UnityEngine;
using System.Collections;

public class player2Shooting : MonoBehaviour {

	public float speed;
	public Rigidbody2D laserPrefab;
	public float rateOfFire;
	public float threshold;
	
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if(Time.time >= threshold)
		{
			if (Input.GetKey ("space")) 
			{
				//creates a Rigidbody2D with for the laster with the coordinates of the spaceship and sets the rotation of the laser to the same as the spaceship
				Rigidbody2D laser = Instantiate(laserPrefab, new Vector3(transform.position.x, transform.position.y, transform.position.z), transform.rotation) as Rigidbody2D;
				
				laser.rigidbody2D.AddForce(transform.up * speed);
				
				threshold = Time.time + rateOfFire;
			}
		}
	}
}

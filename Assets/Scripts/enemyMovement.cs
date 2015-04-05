using UnityEngine;
using System.Collections;

public class enemyMovement : MonoBehaviour {

	public float speed;
	public Transform player1;
	public Transform player2;
	private float angle;
	private Vector3 direction1;
	private Vector3 direction2;
	public Transform borderPrefab;
	public GameObject explosion;
	public AudioSource explosionSound;

	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.tag.Equals("Player") == true) 
		{
			//play explosion sound and play explosion animation
			Instantiate(explosionSound, obj.transform.position, Quaternion.identity);
			Instantiate(explosion, obj.transform.position, Quaternion.identity);
			Destroy(obj.gameObject);
			Destroy(this.gameObject);


		}

	}


	// Update is called once per frame
	void FixedUpdate () 
	{


		if (player1 != null) 
		{
			direction1 = player1.position - transform.position; //vector between player1 and enemy. Has direction.
		}

		if (player2 != null) 
		{
			direction2 = player2.position - transform.position; //vector between player2 and enemy. Has direction.
		}

		if (player1 == null) 
		{
			angle = Mathf.Atan2 (direction2.y, direction2.x) * Mathf.Rad2Deg - 90; //sets angle that enemy needs to rotate to face the target
		}

		if (player2 == null) 
		{
			angle = Mathf.Atan2 (direction1.y, direction1.x) * Mathf.Rad2Deg - 90; //sets angle that enemy needs to rotate to face the target
		}
		if (player1 != null && player2 != null) 
		{
			if (direction1.magnitude < direction2.magnitude) 
			{
				angle = Mathf.Atan2 (direction1.y, direction1.x) * Mathf.Rad2Deg - 90; //sets angle that enemy needs to rotate to face the target
			} 
			else 
			{
				angle = Mathf.Atan2 (direction2.y, direction2.x) * Mathf.Rad2Deg - 90; //sets angle that enemy needs to rotate to face the target
			}
		}


		transform.eulerAngles = new Vector3 (0, 0, angle); //sets enemy line of sight by setting enemy rotation on z axis
		rigidbody2D.AddForce (gameObject.transform.up * speed); //moves object forward

	}
	
}

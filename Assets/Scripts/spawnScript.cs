using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {


	// enemy prefab
	public Transform enemyPrefab;
	public Transform player1;
	public Transform player2;
	private float time;
	private float requiredTime;
	public float respawnTime;


	
	void Start() 
	{  
		requiredTime = 30;
		// Call the 'addEnemy' function every respawnTime seconds
		InvokeRepeating("addEnemy", respawnTime, respawnTime);
	}
	
	// New function to spawn an enemy
	void addEnemy() 
	{  
		time += Time.deltaTime;

		if(time >= requiredTime)
		{		
			respawnTime -= 0.2f;
			requiredTime *= 2; //increase time till game gets harder
		}
			// Variables to store the X position of the spawn object
			float x1 = transform.position.x - renderer.bounds.size.x/2;
			float x2 = transform.position.x + renderer.bounds.size.x/2;
			
			// Randomly pick a point within the spawn object
			Vector3 spawnPoint = new Vector3(Random.Range(x1, x2), transform.position.y);
			
			// Create an enemy at the 'spawnPoint' position
			var enemy = Instantiate(enemyPrefab, spawnPoint, Quaternion.identity) as Transform;

			//set player1 and player2 for enemy to follow
			enemyMovement script =  enemy.gameObject.GetComponent<enemyMovement> ();
			script.player1 = player1;
			script.player2 = player2;


		
	}




}

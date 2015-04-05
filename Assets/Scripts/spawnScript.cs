using UnityEngine;
using System.Collections;

public class spawnScript : MonoBehaviour {


	// enemy prefab
	public Transform enemyPrefab;
	
	// Variable to know how fast we should create new enemies
	public float respawnTime;
	
	void Start() 
	{  
		// Call the 'addEnemy' function every respawnTime seconds
		InvokeRepeating("addEnemy", respawnTime, respawnTime);
	}
	
	// New function to spawn an enemy
	void addEnemy() 
	{  
		// Variables to store the X position of the spawn object
		float x1 = transform.position.x - renderer.bounds.size.x/2;
		float x2 = transform.position.x + renderer.bounds.size.x/2;
		
		// Randomly pick a point within the spawn object
		Vector3 spawnPoint = new Vector3(Random.Range(x1, x2), transform.position.y);
		
		// Create an enemy at the 'spawnPoint' position
		Instantiate(enemyPrefab, spawnPoint, Quaternion.identity);
	}


}

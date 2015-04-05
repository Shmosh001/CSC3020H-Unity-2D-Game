using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour 
{
	public GameObject explosion;
	public AudioSource explosionSound;
	private winningCondition winningCondition;

	void Start()
	{
		GameObject obj = GameObject.FindWithTag ("Winning Condition");
		if (obj != null) 
		{
			winningCondition = obj.GetComponent<winningCondition>();
		}
	}

	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.tag.Equals("Player") == false && obj.tag.Equals("Laser") == false && obj.tag.Equals("Border") == false) 
		{
			//play explosion sound and play explosion animation
			Instantiate(explosionSound, obj.transform.position, Quaternion.identity);
			Instantiate(explosion, obj.transform.position, Quaternion.identity);
			Destroy(obj.gameObject);
			Destroy(this.gameObject);
			winningCondition.addScore();


		}

		if (obj.tag.Equals ("Border") == true) 
		{
			Destroy(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

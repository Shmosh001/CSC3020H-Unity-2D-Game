using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour 
{
	public GameObject explosion;
	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.tag.Equals("Player") == false && obj.tag.Equals("Laser") == false) 
		{
			Instantiate(explosion, obj.transform.position, Quaternion.identity);
			Destroy(obj.gameObject);
			Destroy(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

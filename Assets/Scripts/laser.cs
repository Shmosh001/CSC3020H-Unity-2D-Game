using UnityEngine;
using System.Collections;

public class laser : MonoBehaviour 
{

	void OnTriggerEnter2D(Collider2D obj)
	{
		if (obj.tag.Equals("Player") == false && obj.tag.Equals("Laser") == false) 
		{
			Destroy(obj.gameObject);
			Destroy(this.gameObject);
		}
	}
	
	// Update is called once per frame
	void Update () 
	{
	
	}
}

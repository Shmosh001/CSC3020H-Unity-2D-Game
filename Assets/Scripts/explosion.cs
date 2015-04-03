using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Invoke ("Die", 2.3f); //calls the destry method in 2.3f time units
	}

	void Die()
	{
		Destroy (gameObject); //destroy explosion object
	}

}

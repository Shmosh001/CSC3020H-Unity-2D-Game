using UnityEngine;
using System.Collections;

public class explosion : MonoBehaviour {
	public float time;
	// Use this for initialization
	void Start () {
		Invoke ("Die", time); //calls the destry method in 2.3f time units
	}

	void Die()
	{
		Destroy (gameObject); //destroy explosion object
	}

}

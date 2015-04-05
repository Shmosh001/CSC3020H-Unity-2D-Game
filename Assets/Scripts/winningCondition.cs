using UnityEngine;
using System.Collections;

public class winningCondition : MonoBehaviour {
	public Transform player1;
	public Transform player2;
	public Transform border1;
	public Transform border2;
	public Transform border3;
	public Transform border4;
	private int score;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (player1 == null && player2 == null) 
		{
			Destroy(border1);
			Destroy(border2);
			Destroy(border3);
			Destroy(border4);
		

		}
	}
}

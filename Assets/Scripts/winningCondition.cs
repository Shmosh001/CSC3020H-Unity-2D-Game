using UnityEngine;
using System.Collections;

public class winningCondition : MonoBehaviour {
	public Transform player1;
	public Transform player2;
	public GameObject border1;
	public GameObject border2;
	public GameObject border3;
	public GameObject border4;

	public GUIText scoreText;
	public int score;

	// Use this for initialization
	void Start () 
	{
		score = 0;
		updateScore ();
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

	public void addScore()
	{
		score += 10;
		updateScore ();
	}
	
	void updateScore()
	{
		scoreText.text = "Score: " + score;
	}
}

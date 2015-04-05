using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	void OnGUI()
	{
		GUI.Label(new Rect(30, 10, 100, 20), "Score: ", "<color=red><size=40>Lose</size></color>");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

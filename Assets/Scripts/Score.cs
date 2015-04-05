using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	void OnGUI()
	{
		//create new font and change size and colour.
		GUIStyle font = new GUIStyle ();
		font.fontSize = 32;
		font.normal.textColor = Color.white;
		//new label to display score
		GUI.Label(new Rect(30, 10, 100, 20), "Score: ", font);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

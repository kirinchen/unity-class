using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	// Use this for initialization
	void Start () {
		guiText.fontSize = Screen.height / 10;
		guiText.text = string.Format (guiText.text,0);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

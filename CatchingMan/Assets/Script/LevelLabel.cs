using UnityEngine;
using System.Collections;

public class LevelLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		float h = Screen.height / 15 * 0.8f;
		guiText.fontSize = (int)h;
		gameObject.guiText.text = "Level:"+PlayerPrefs.GetInt ("LEVEL");
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

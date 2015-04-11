using UnityEngine;
using System.Collections;

public class LevelLabel : MonoBehaviour {

	// Use this for initialization
	void Start () {
		gameObject.guiText.text = "Level:"+PlayerPrefs.GetInt ("LEVEL");
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

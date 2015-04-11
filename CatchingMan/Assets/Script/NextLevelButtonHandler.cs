using UnityEngine;
using System.Collections;

public class NextLevelButtonHandler : MonoBehaviour {

	private Scene scene;

	// Use this for initialization
	void Start () {
		scene = GameObject.Find ("Scene").GetComponent<Scene> ();
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnMouseDown(){
		Application.LoadLevel ("Level01");
		int l = PlayerPrefs.GetInt ("LEVEL") + 1;
		PlayerPrefs.SetInt ("LEVEL",l);
	}
}

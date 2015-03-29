using UnityEngine;
using System.Collections;

public class StartButtonListener : MonoBehaviour {

	public Sprite buutonUpImg;
	public Sprite buutonDownImg;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnMouseUp(){
		GetComponent<SpriteRenderer> ().sprite = buutonUpImg;
		Application.LoadLevel ("Level01");
	}

	void OnMouseDown(){
		GetComponent<SpriteRenderer> ().sprite = buutonDownImg;
	}
}

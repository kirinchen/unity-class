using UnityEngine;
using System.Collections;

public class Point : MonoBehaviour {

	public Sprite[] sprites;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void setPoint(int p ){
		GameObject playerObj = GameObject.Find ("Player");
		int tenNum = p / 10;
		int oneNum = p % 10;
		GameObject tenObj = transform.FindChild ("Digital_0").gameObject;
		GameObject oneObj = transform.FindChild ("Digital_1").gameObject;
		tenObj.GetComponent<SpriteRenderer>().sprite = sprites[tenNum];
		oneObj.GetComponent<SpriteRenderer>().sprite = sprites[oneNum];
		playAnitmation ();
		Vector3 thisPos = transform.position;
		Vector3 pos = new Vector3 (playerObj.transform.position.x,thisPos.y,thisPos.z);
		transform.position = pos;

	}

	public void playAnitmation(){
		animation.Play();
		GameObject tenObj = transform.FindChild ("Digital_0").gameObject;
		tenObj.animation.Play ();
		GameObject oneObj = transform.FindChild ("Digital_1").gameObject;
		oneObj.animation.Play ();
	}

	public void killMe(){
		Destroy (gameObject);
		Destroy (this);
	}
}

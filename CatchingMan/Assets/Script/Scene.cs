using UnityEngine;
using System.Collections;
using WebSocketSharp;

public class Scene : MonoBehaviour {

	public GameObject Wall;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}


	private void SetupWall(){
		float Distance = Camera.main.orthographicSize * Camera.main.aspect * 1.1f;
		GameObject leftWall = Instantiate(Wall) as GameObject;
		leftWall.transform.position = new Vector3 (-Distance,0,0);
		GameObject rightWall = Instantiate(Wall) as GameObject;
		rightWall.transform.position = new Vector3 (Distance,0,0);

	}
}

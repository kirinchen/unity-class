using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {

	public GameObject Wall;

	// Use this for initialization
	void Start () {
		SetupWall();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}

	private void SetupWall(){

		//GameObject Wall = GameObject.Find ("Wall");
		Debug.Log (Wall);
		float Distance = Camera.main.orthographicSize * Camera.main.aspect * 1.25f;
		GameObject leftWall = Instantiate(Wall) as GameObject;
		leftWall.transform.position = new Vector3 (-Distance,0,0);
		GameObject rightWall = Instantiate(Wall) as GameObject;
		rightWall.transform.position = new Vector3 (Distance,0,0);
		
	}
}

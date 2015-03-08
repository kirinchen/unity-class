using UnityEngine;
using System.Collections;

public class WoodBucket : MonoBehaviour {

	private Vector3 StartPos, EndPos;
	private bool _IsMouseDown = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){

			StartPos = Input.mousePosition;
			_IsMouseDown = true;
		}
		if(Input.GetMouseButtonUp(0)){
			_IsMouseDown = false;
		}
		if(_IsMouseDown){

			EndPos = Input.mousePosition;
			DetectGuesture();
		}
	}

	private void DetectGuesture(){
		Vector3 p1 = Camera.main.ScreenToWorldPoint (StartPos);
		Vector3 p2 = Camera.main.ScreenToWorldPoint (EndPos);
		float len = (p2.x - p1.x)*2;

		Vector3 p3 = new Vector3 (transform.position.x+len,transform.position.y,transform.position.z);
		float w = (Camera.main.orthographicSize * Camera.main.aspect) - (renderer.bounds.size.x / 2);

		p3.x = Mathf.Max (p3.x, -w);
		p3.x = Mathf.Min (p3.x, w);
		Debug.Log (p3.x);
		transform.position = p3;

		StartPos = EndPos;

	}
}

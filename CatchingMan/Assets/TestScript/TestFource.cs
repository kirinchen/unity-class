using UnityEngine;
using System.Collections;

public class TestFource : MonoBehaviour {

	private bool first = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (first) {
			first = false;
			rigidbody2D.AddForce (new Vector2(10, 0));
			rigidbody2D.AddForce (new Vector2(0, 30));	
		}

	}
}

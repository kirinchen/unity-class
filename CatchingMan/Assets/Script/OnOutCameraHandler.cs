using UnityEngine;
using System.Collections;

public class OnOutCameraHandler : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject go = gameObject;
		if(go.renderer.isVisible) {
			Destroy(go);
		}
	
	}
}

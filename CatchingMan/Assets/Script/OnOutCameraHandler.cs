using UnityEngine;
using System.Collections;

public class OnOutCameraHandler : MonoBehaviour {

	private bool isFirstShow = false;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		GameObject go = gameObject;
		if (go.renderer.isVisible) {
			isFirstShow = true;
		} else {
			if(isFirstShow){
				Destroy(go);
				Destroy(this);
			}
		}
	
	}
}

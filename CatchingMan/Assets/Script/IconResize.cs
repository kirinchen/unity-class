using UnityEngine;
using System.Collections;

public class IconResize : MonoBehaviour {



	// Use this for initialization
	void Start () {
		float h = Screen.height/10 * 0.7f;
		guiTexture.pixelInset = new Rect (-h/2,-h/2,h,h);

	}



	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class FruitValue : MonoBehaviour {

	public int Value = 10;
	private Scene scene;

	// Use this for initialization
	void Start () {
		scene = GameObject.Find ("Scene").GetComponent<Scene> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(scene.levelComplated || scene.gameOvered) {
			Destroy (this.gameObject);
			Destroy (this);
		}
	}
}

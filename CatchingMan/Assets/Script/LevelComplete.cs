using UnityEngine;
using System.Collections;

public class LevelComplete : MonoBehaviour {

	private Scene scene;
	private GameObject nextLevelButton;
	private bool isAnimationPlayed = false;

	// Use this for initialization
	void Start () {
		scene = GameObject.Find ("Scene").GetComponent<Scene> ();
		nextLevelButton = GameObject.Find ("NextLevelButton");
	}
	
	// Update is called once per frame
	void Update () {
		if(scene.levelComplated && !isAnimationPlayed){
			isAnimationPlayed = true;
			gameObject.animation.Play();
		}
	}

	public void showNextLevelButton(){
		nextLevelButton.collider2D.enabled = true;
		nextLevelButton.renderer.enabled = true;
	}
}

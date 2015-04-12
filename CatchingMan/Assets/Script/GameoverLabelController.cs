using UnityEngine;
using System.Collections;

public class GameoverLabelController : MonoBehaviour {
	private Scene scene;
	private bool isAnimationPlayed = false;
	private GameObject restartButtom;

	// Use this for initialization
	void Start () {
		scene = GameObject.Find ("Scene").GetComponent<Scene> ();
		restartButtom = GameObject.Find ("RestartButton");
	}
	
	// Update is called once per frame
	void Update () {
		if(scene.gameOvered && !isAnimationPlayed){
			isAnimationPlayed = true;
			gameObject.animation.Play();
		}
	
	}

	public void showNextLevelButton(){
		restartButtom.collider2D.enabled = true;
		restartButtom.renderer.enabled = true;
	}
}

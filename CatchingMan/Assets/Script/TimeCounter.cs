using UnityEngine;
using System.Collections;

public class TimeCounter : MonoBehaviour {

	private int gameMaxTime = 10;
	private float startTime;
	private Scene scene;


	// Use this for initialization
	void Start () {
		scene = GameObject.Find ("Scene").GetComponent<Scene> ();
		startTime = Time.time;
		float h = Screen.height / 15 * 0.8f;
		guiText.fontSize = (int)h;
	
	}
	
	// Update is called once per frame
	void Update () {
		if(scene.gameOvered && scene.levelComplated){
			return;
		}
		int prieod = (int)(Time.time - startTime);
		int finalT = gameMaxTime - prieod;
		if(finalT <=0){
			finalT = 0;
			scene.gameOvered = true;
		}
		setTimeCount (finalT);
	}

	private void setTimeCount(int t){
		int min = t / 60;
		int sec = t % 60;
		guiText.text = min.ToString("00") + ":" + sec.ToString("00");
	}
}

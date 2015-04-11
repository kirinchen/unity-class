using UnityEngine;
using System.Collections;

public class TimeCounter : MonoBehaviour {

	private int gameMaxTime = 90;
	private float startTime;


	// Use this for initialization
	void Start () {
		startTime = Time.time;
		float h = Screen.height / 15 * 0.8f;
		guiText.fontSize = (int)h;
	
	}
	
	// Update is called once per frame
	void Update () {
		int prieod = (int)(Time.time - startTime);
		setTimeCount (gameMaxTime - prieod);
	}

	private void setTimeCount(int t){
		int min = t / 60;
		int sec = t % 60;
		guiText.text = min.ToString("00") + ":" + sec.ToString("00");
	}
}

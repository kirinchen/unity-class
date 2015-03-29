using UnityEngine;
using System.Collections;

public class Score : MonoBehaviour {

	private string tamplate = "Score:{0}";
	public int TotalScore= 0;

	// Use this for initialization
	void Start () {
		guiText.fontSize = Screen.height / 10;
	
	}


	public void plusScore(int score){
		TotalScore += score;
		guiText.text = string.Format (tamplate,TotalScore);	
	}

	// Update is called once per frame
	void Update () {
		guiText.text = string.Format (tamplate,TotalScore);	
	}
}

using UnityEngine;
using System.Collections;

public class NumResize : MonoBehaviour {

	private int currentCount=0 ;
	public int maxCount = 3;

	// Use this for initialization
	void Start () {
		float h = Screen.height / 10 * 0.7f;
		guiText.fontSize = (int)h;
		showCount();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void plusCount(){
				if (currentCount < maxCount) {
						currentCount ++;
						showCount ();
				} 
	}

	public bool isLimt(){
		return currentCount >= maxCount;
	}

	public void showCount(){
		guiText.text = maxCount +"/"+currentCount;
	}
}

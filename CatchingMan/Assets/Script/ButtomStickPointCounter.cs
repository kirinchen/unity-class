using UnityEngine;
using System.Collections;


public class ButtomStickPointCounter : MonoBehaviour {

	Score score = null;

	// Use this for initialization
	void Start () {
		score = GameObject.Find ("Score").GetComponent<Score> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		calcScore (collider.gameObject);
		//EditorUtility.DisplayDialog ("Title here", collider.gameObject.name, "OK");
		Destroy (collider.gameObject);
		//var objPos = collider.gameObject.transform.position;
		//objPos.Set(objPos.x, -2, objPos.z);
		audio.Play ();

	}


	private void calcScore(GameObject go){

		FruitValue fv = go.GetComponent<FruitValue> ();
		if (fv != null) {
			int value = fv.Value;
			score.TotalScore += value;	
		}
	}

}

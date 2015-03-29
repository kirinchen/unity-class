using UnityEngine;
using System.Collections;


public class ButtomStickPointCounter : MonoBehaviour {

	Score score = null;


	public GameObject[] conditions ;

	// Use this for initialization
	void Start () {
		score = GameObject.Find ("Score").GetComponent<Score> ();
		//doLevelComplete ();
		
	}
	
	// Update is called once per frame
	void Update () {

	}

	void OnTriggerEnter2D(Collider2D collider){
		calcScore (collider.gameObject);
		//EditorUtility.DisplayDialog ("Title here", collider.gameObject.name, "OK");

		calcConditions (collider.gameObject);
		setupLevelComplete ();
		Destroy (collider.gameObject);
		//var objPos = collider.gameObject.transform.position;
		//objPos.Set(objPos.x, -2, objPos.z);
		audio.Play ();

	}

	private void setupLevelComplete(){
		int isMaxConditionCount = 0;
	}

	private void calcConditions(GameObject colliderO ){

		for(int i=0;i<conditions.Length;i++){
			GameObject group = conditions[i];
			calcCondition(colliderO,group);

		}
	}



	private void doLevelComplete(){
		GameObject lc = GameObject.Find ("LevelComplete");
		lc.rigidbody2D.isKinematic = false;
	}

	private void calcCondition(GameObject colliderO,GameObject group){
		GameObject icon2 = getGroupGameObject (group,"Icon");
		GameObject num2 = getGroupGameObject (group,"Num");
		int idx = colliderO.name.IndexOf (icon2.guiTexture.texture.name);
		if(idx!=-1){
			num2.GetComponent<NumResize>().plusCount();
		}

	}

	static public GameObject getGroupGameObject(GameObject fromGameObject, string withName) {
		Transform ts = fromGameObject.transform.Find (withName);
		return (GameObject)ts.gameObject;
	}


	private void calcScore(GameObject go){

		FruitValue fv = go.GetComponent<FruitValue> ();
		if (fv != null) {
			int value = fv.Value;
			score.TotalScore += value;	
		}
	}

}

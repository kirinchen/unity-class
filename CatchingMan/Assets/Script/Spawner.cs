using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	private float BeginTime ;

	public float SpawnTime = 2;
	public GameObject[] objList;

	// Use this for initialization
	void Start () {
		BeginTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		if((Time.time-BeginTime)>SpawnTime){
			int rCount = Random.Range(1,10);
			for(int i=0;i<rCount;i++){
				CreateAObj();
			}
		}

	}

	private void CreateAObj(){
		int idx = Random.Range(0,objList.Length);
		GameObject newObj = Instantiate(objList[idx]) as GameObject;
		newObj.transform.position = transform.position;
		
		BeginTime = Time.time;
	}
}

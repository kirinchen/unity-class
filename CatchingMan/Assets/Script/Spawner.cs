using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	private float Distance;
	private float BeginTime ;

	public float SpawnTime = 2;
	public GameObject[] objList;
	public float MoveSpeed = 2;
	private  int MAX_CREATE_COUNT = 3;

	// Use this for initialization
	void Start () {
		Distance = Camera.main.orthographicSize * Camera.main.aspect * 2 * 0.9f;
		BeginTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {

		shiftPos ();

		if((Time.time-BeginTime)>SpawnTime){
			int rCount = Random.Range(1,MAX_CREATE_COUNT);
			for(int i=0;i<rCount;i++){
				CreateAObj();
			}
			audio.Play();
		}

	}

	private void shiftPos(){
		float newPos = Mathf.PingPong (Time.time*MoveSpeed,Distance) - (Distance/2);
		transform.position = new Vector3 (newPos,transform.position.y,transform.position.z);
	}

	private void CreateAObj(){
		int idx = Random.Range(0,objList.Length);
		GameObject newObj = Instantiate(objList[idx]) as GameObject;
		newObj.transform.position = transform.position;
		
		BeginTime = Time.time;
	}
}

using UnityEngine;
using System.Collections;

public class Bomb : MonoBehaviour {

	public GameObject fire;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D collider){
		createManyFire ();
		Destroy (this.gameObject);
	}

	private void createManyFire(){
		for(int i=0;i<40;i++){
			createFire ();
		}
	}

	private void createFire(){
		GameObject newObj = Instantiate(fire) as GameObject;
		Vector3 op = transform.position;
		op.x = op.x + Random.Range (-0.1f,0.1f);
		op.y = op.y + Random.Range (-0.1f,0.1f);
		newObj.transform.position = op;
		float rx = Random.Range (300, 2000f);
		float ry = Random.Range (300, 2200f);
		if(Random.Range(-1f,1f)>0f){
			rx*=-1;
		}
		if(Random.Range(-1f,1f)>0){
			ry*=-1;
		}
		newObj.rigidbody2D.AddForce (new Vector2(rx, ry));

		newObj.animation.Play ();
	}


}

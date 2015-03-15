using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {


	private	Vector3 StartPos ;
	private Vector3 EndPos ;
	private bool _IsMouseDown = false;
	private GameObject bucket;
	private bool isMoveRight = true;
	private Animator selfAnimator;

	// Use this for initialization
	void Start () {
		bucket = GameObject.Find ("woodbucket");
		selfAnimator = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetMouseButtonDown(0)){

			StartPos = Input.mousePosition;
			_IsMouseDown = true;
		}
		if(Input.GetMouseButtonUp(0)){
			_IsMouseDown = false;
		}
		if(_IsMouseDown){
			EndPos = Input.mousePosition;
			selfAnimator.SetBool("isRun",false);
			DetectGuesture();
		}

		updatePlayerMoveStyle ();
	}

	private void updatePlayerMoveStyle(){
		Vector3 scale = transform.localScale;
		bool needChangetRight = scale.x < 0 && isMoveRight;
		bool needChangetLeft = scale.x > 0 && !isMoveRight;
		if (needChangetLeft || needChangetRight) {
			scale.x *= -1f;		
			transform.localScale = scale;
		}
	}

	private void DetectGuesture(){

	
		Vector3 p1 = Camera.main.ScreenToWorldPoint (StartPos);
		Vector3 p2 = Camera.main.ScreenToWorldPoint (EndPos);
		float len = (p2.x - p1.x)*2;

		Vector3 p3 = new Vector3 (transform.position.x+len,transform.position.y,transform.position.z);
		float w = (Camera.main.orthographicSize * Camera.main.aspect) - (bucket.renderer.bounds.size.x / 2);

		p3.x = Mathf.Max (p3.x, -w);
		p3.x = Mathf.Min (p3.x, w);
		transform.position = p3;
		StartPos = EndPos;

		updateMoveFlag (len);

	}

	private void updateMoveFlag(float len){
		if (Mathf.Abs (len) > 0.2f) {
			if(len > 0){
				isMoveRight = true;
			}else if(len <0){
				isMoveRight = false;
			}

			selfAnimator.SetBool("isRun",true);
		}
	}
}

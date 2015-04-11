using UnityEngine;
using System.Collections;

public class Scene : MonoBehaviour {

	public GameObject Wall;
	public bool levelComplated = false;

	public GameObject[] conditions ;

	// Use this for initialization
	void Start () {

		SetupWall();
		chooseCoditionIcons ();
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit();
		}
	}

	private void SetupWall(){

		//GameObject Wall = GameObject.Find ("Wall");
		Debug.Log (Wall);
		float Distance = Camera.main.orthographicSize * Camera.main.aspect * 1.4f;
		GameObject leftWall = Instantiate(Wall) as GameObject;
		leftWall.transform.position = new Vector3 (-Distance,0,0);
		GameObject rightWall = Instantiate(Wall) as GameObject;
		rightWall.transform.position = new Vector3 (Distance,0,0);
		
	}

	private void chooseCoditionIcons(){
		Spawner sp = GameObject.Find ("Spawner1").GetComponent<Spawner> ();
		ArrayList myArrayList = new ArrayList();
		myArrayList.AddRange (sp.objList);
		int conditionCount = Random.Range (1, conditions.Length+1);
		for(int i=0;i<conditionCount;i++){
			GameObject group = conditions[i];
			GameObject icon = getGroupGameObject (group,"Icon");
			GameObject num = getGroupGameObject (group,"Num");
			int idx = Random.Range(0,myArrayList.Count);
			GameObject spriteO = (GameObject)myArrayList[idx];
			setupOneConditionIcon (spriteO,icon);
			setupConditionNum(num);
			myArrayList.RemoveAt(idx);
		}
	}

	private void setupConditionNum(GameObject num){
		num.guiText.enabled = true;
		NumResize numController = num.GetComponent<NumResize> ();
		numController.maxCount = Random.Range (1, 3);
		numController.showCount ();
	}

	private void setupOneConditionIcon(GameObject spriteO,GameObject conditionO){
		conditionO.guiTexture.enabled = true;
		Sprite sprite = spriteO.GetComponent<SpriteRenderer> ().sprite;
		Texture2D t2d = textureFromSprite (sprite);
		conditionO.guiTexture.texture = t2d;
		conditionO.guiTexture.texture.name = sprite.name;
	}
	
	public static Texture2D textureFromSprite(Sprite sprite){
		if(sprite.rect.width != sprite.texture.width){
			Texture2D newText = new Texture2D((int)sprite.rect.width,(int)sprite.rect.height);
			Color[] newColors = sprite.texture.GetPixels((int)sprite.textureRect.x, 
			                                             (int)sprite.textureRect.y, 
			                                             (int)sprite.textureRect.width, 
			                                             (int)sprite.textureRect.height );
			newText.SetPixels(newColors);
			newText.Apply();
			return newText;
		} else
			return sprite.texture;
	}

	public static GameObject getGroupGameObject(GameObject fromGameObject, string withName) {
		Transform ts = fromGameObject.transform.Find (withName);
		return (GameObject)ts.gameObject;
	}
	
}

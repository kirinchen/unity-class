﻿using UnityEngine;
using System.Collections;

public class ButtomObjectDestryer : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


	}

	void OnTriggerEnter2D(Collider2D collider){
		//EditorUtility.DisplayDialog ("Title here", collider.gameObject.name, "OK");
		Destroy (collider.gameObject);
		//var objPos = collider.gameObject.transform.position;
		//objPos.Set(objPos.x, -2, objPos.z);
	}
}

using UnityEngine;
using System.Collections;
using WebSocketSharp;


public class TestWebSocket : MonoBehaviour {

	// Use this for initialization
	void Start () {
		testWebSocket ();
	}

	private void testWebSocket(){
		Debug.Log ("TEST");
		using (var ws = new WebSocket ("ws://127.0.0.1:8080/siege/gameWs/673/4lv9oabc/websocket")) {

			ws.SetCookie(new WebSocketSharp.Net.Cookie("JSESSIONID","77E34D918DAF54294CDD48D94803EAB3"));
			ws.OnMessage += (sender, e) =>
				Debug.Log ("Laputa says: " + e.Data);
			ws.OnError += (sender, e) =>
				Debug.Log ("Laputa says: " + e.Message);
			ws.Connect ();
			ws.Send ("BALUS");
			
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}

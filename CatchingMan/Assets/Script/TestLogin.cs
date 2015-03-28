using UnityEngine;
using System.Collections;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;

public class TestLogin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log("Request start...");
		
		
		var url = " http://localhost:8080/siege/api/v1/auth/login?type=REST_API";
		var request = WebRequest.Create(url) as HttpWebRequest;
		request.Method = "POST";
		request.ContentType = "application/json";
		string param = "{\"email\":\"a29243685@msn.com\",\"password\":\"asdfghjkl\"}";
		string result;
		
		try
		{
			byte[] paramData = Encoding.UTF8.GetBytes(param);
			using (var reqStream = request.GetRequestStream())
			{
				reqStream.Write(paramData, 0, paramData.Length);
			}
			
			using (var response = request.GetResponse())
			{
				var sr = new StreamReader(response.GetResponseStream());
				result = sr.ReadToEnd();
				sr.Close();
			}
		}
		catch (Exception ex)
		{
			Debug.Log("Error: " + ex.Message);
			return;
		}
		
		Dictionary<string, string> responseData;
		responseData = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
		
		
		Debug.Log("OK......jSessionId is: " + responseData["jSessionId"]);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

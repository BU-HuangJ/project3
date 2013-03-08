using UnityEngine;
using System.Collections;

public class NetworkObject : MonoBehaviour {

	// Use this for initialization
	void Start () {
		test_bcrypt();
		//test_get();
		//test_post();
		//test_login();
		
		//StartCoroutine(WaitForRequest(www));
	}
	
	void test_bcrypt() {
		// $2a$10$kc4GB8mgo3IRu6QGc.Ffxe8Zql2yodIYaNQBWYoRVYqjik39DWiTm
		//Debug.Log( BCrypt.Net.BCrypt.HashPassword("Rock206301", "$2a$10$kc4GB8mgo3IRu6QGc.Ffxe") );
		Debug.Log( BCrypt.Net.BCrypt.HashPassword("12345678") );
		Debug.Log( BCrypt.Net.BCrypt.HashPassword("12345678") );
	}
	
	void test_get() {
		string url = "https://swift-grades.herokuapp.com/assignments.json";
		UnityEngine.WWW site  = new UnityEngine.WWW(url);
		if (site.error != null) {
			Debug.Log("offline");
		} else {
			this.print(site);
		}
	}
	
	void test_post() {
		string url = "https://swift-grades.herokuapp.com/assignments";
		// Create a Web Form
		WWWForm form = new WWWForm();
    	form.AddField("assignment[name]", "A3");
    	form.AddField("assignment[description]", "strings");
    	form.AddField("assignment[points]", "5");
    	form.AddField("assignment[language]", "ruby");
	    // Upload
	    UnityEngine.WWW site = new UnityEngine.WWW(url, form);
		if (site.error != null) {
			Debug.Log("offline");
		} else {
			while(!site.isDone){
			}
			string token = site.text.ToString();
			Debug.Log( token );
		}
	}
	
	void test_login() {
		string url = "https://swift-grades.herokuapp.com";
		// Create a Web Form
		WWWForm form = new WWWForm();
    	form.AddField("username", "huangj");
    	form.AddField("password", BCrypt.Net.BCrypt.HashPassword("Rock206301") );
	    // Upload
	    UnityEngine.WWW site = new UnityEngine.WWW(url, form);
		if (site.error != null) {
			Debug.Log("offline");
		} else {
			while(!site.isDone){
			}
			string token = site.text.ToString();
			Debug.Log( token );
		}
	}
	
	void print(UnityEngine.WWW site) {
		while(!site.isDone){
		}
		string token = site.text.ToString();
		
		System.Collections.Generic.List<AssignmentObject> assignments = new System.Collections.Generic.List<AssignmentObject>();
		JSONObject obj = new JSONObject(token);
		foreach(JSONObject j in obj.list){
			assignments.Add( new AssignmentObject(j) );
		}
		
		foreach(AssignmentObject assignment in assignments) {
			Debug.Log( assignment.to_str() );
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	IEnumerator WaitForRequest(WWW www)
	{
		yield return www;
		 
		// check for errors
		if (www.error == null)
		{
			Debug.Log("WWW Ok!: " + www.text);
		} else {
			Debug.Log("WWW Error: "+ www.error);
		}
	}
}

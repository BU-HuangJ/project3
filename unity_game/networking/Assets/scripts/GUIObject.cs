using UnityEngine;
using System.Collections;

public class GUIObject : MonoBehaviour {
	
	private string message = "switched";
	private bool enter = false;
	//private TCPNetworkScript tcp = new TCPNetworkScript("129.62.151.75", 9999);
	//private LoginObject lob = new LoginObject();
	
	void OnGUI() {
		do_GUI();
	}
	
	void do_GUI() {
		// was the enter key pressed?
		this.enter = UnityEngine.Event.current.Equals(UnityEngine.Event.KeyboardEvent("return"));
		
		if (this.enter) {
			this.do_stuff();
			/*
			JSONObject job = JSONObject.obj;
			job.AddField("type", "login");
			job.AddField("member", "foo@example.com");
			job.AddField("password", "hello");
			Debug.Log(job.ToString());
			tcp.SendData( job.ToString()+'\n' );
			//*/
		}
		//message = UnityEngine.GUI.TextField( new UnityEngine.Rect( (UnityEngine.Screen.width/2)-50, 100, 100, 100 ), this.message, 25 );
		//message = UnityEngine.GUI.TextField( new UnityEngine.Rect( (UnityEngine.Screen.width/2)-50, 100, 100, 100 ), this.message, 25 );
		//message = UnityEngine.GUI.TextField( new UnityEngine.Rect( (UnityEngine.Screen.width/2)-50, 100, 100, 100 ), this.message, 25 );
		
		// draw basic lable
		UnityEngine.GUI.Label( new UnityEngine.Rect( (UnityEngine.Screen.width/2)-50, 50, 100, 100 ), "Menu" );
		
		// set the name of the TextField to "text_field"
		UnityEngine.GUI.SetNextControlName("text_field");
		// draw a text field to modify the message
		message = UnityEngine.GUI.TextField( new UnityEngine.Rect( (UnityEngine.Screen.width/2)-50, 100, 100, 100 ), this.message, 25 );
		// if the user hits enter while in the TextField, then write the message to the debug log
		if ( this.enter && UnityEngine.GUI.GetNameOfFocusedControl() == "text_field" ) {
			Debug.Log( this.message );
			this.enter = false; // also set enter to false
		}
		// draw basic button; if the button is pressed, then write the message to the debug log
		if ( UnityEngine.GUI.Button( new UnityEngine.Rect( (UnityEngine.Screen.width*3/4), 50, 100, 100 ), "Send" ) ) {
			Debug.Log( this.message );
		}
		
		// check to see if the enter key is pressed
		if ( UnityEngine.Event.current.Equals(UnityEngine.Event.KeyboardEvent("return")) ) this.enter = true;
		// if the enter key has been pressed outside of the TextField:
		if (this.enter) {
			// draw a button; if the button is pressed:
			if ( UnityEngine.GUI.Button( new UnityEngine.Rect( (UnityEngine.Screen.width*1/4), 50, 100, 100 ), new UnityEngine.GUIContent("Off", "click to turn off") ) ) {
				Debug.Log("entered");
				// then turn the button off
				this.enter = false;
			}
			// if the mouse is hovering over the button, then draw the tooltip
			UnityEngine.GUI.Label(new Rect( (UnityEngine.Screen.width*1/4), 30, 100, 100 ), GUI.tooltip);
		}
	}
	
	void do_stuff() {
		TCPNetworkScript tcp = new TCPNetworkScript();
		JSONObject job = JSONObject.obj;
		job.AddField("type", "login");
		job.AddField("member", "testme1@test.com");
		job.AddField("password", "12345678");
		tcp.SendData("129.62.151.75", 9999, job.ToString()+'\n');
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

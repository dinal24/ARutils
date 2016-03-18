using UnityEngine;
using System.Collections;

public class BackScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Escape)) 
			Application.LoadLevel (0);
	}

	GUIStyle gFontstyle;
	string bText;
	
	void OnGUI(){
		gFontstyle = new GUIStyle (GUI.skin.button);
		gFontstyle.fontSize = Screen.height / 36;
		
		int buttonWidth;
		int buttonHeight;
		
		if (Screen.width > Screen.height) {
			buttonWidth = Screen.width/5;
			buttonHeight = Screen.width/20;	
		} else {
			buttonWidth = Screen.height/5;
			buttonHeight = Screen.height/20;	
		}

		float px = Mathf.Max ((0.1f * Screen.width / 3) - (buttonWidth / 2), 10);
		float py = Mathf.Max ((0.1f * Screen.height / 3) - (buttonHeight / 2), 10);
		
		Rect buttonART = new Rect(
			px,
			py,
			buttonWidth,
			buttonHeight
			);		
		if(GUI.Button(buttonART,"Back",gFontstyle))
		{
			Application.LoadLevel(0);
		}
	}
}

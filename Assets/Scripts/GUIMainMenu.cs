using UnityEngine;
using System.Collections;

public class GUIMainMenu : MonoBehaviour {

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

		
		Rect buttonART = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1.0f * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);		
		if(GUI.Button(buttonART,"AR Target",gFontstyle))
		{
			Application.LoadLevel(1);
		}

		Rect buttonVid = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(1.5f * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		if(GUI.Button(buttonVid,"Video",gFontstyle)){
			Application.LoadLevel(2);
		}

		Rect buttonTerrain = new Rect(
			Screen.width / 2 - (buttonWidth / 2),
			(2.0f * Screen.height / 3) - (buttonHeight / 2),
			buttonWidth,
			buttonHeight
			);
		if(GUI.Button(buttonTerrain,"Smart Terrain",gFontstyle)){
			Application.LoadLevel(3);
		}

	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape)) 
			Application.Quit();
	}
}

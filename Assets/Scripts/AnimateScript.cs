using UnityEngine;
using System.Collections;


public class AnimateScript : MonoBehaviour {

	public static AnimateScript Instance;
	void Awake()
	{
		//the singleton
		if (Instance != null)
		{
			Debug.LogError("Multiple instances of SoundEffectsHelper!");
		}
		Instance = this;
	}

	public void PlayPause(bool play){
		if (play) {
			animation.enabled = true;
			animation.Play();
		} else {
			animation.enabled = false;
		}
	}

	// Use this for initialization
	void Start () {
		PlayPause (true);
	}
	
	// Update is called once per frame
	void Update () {
		//if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began && (Time.time-touchedAt) > 0.2f || Input.GetMouseButtonDown(0)) {
		if(Input.GetMouseButtonDown(0)){
			Debug.Log("Touched");
			if (animation.enabled)
				PlayPause(false);
			else
				PlayPause(true);
		}
	}
}

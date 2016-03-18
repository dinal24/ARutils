using UnityEngine;
using System.Collections;

public class MoviePlay : MonoBehaviour {
	public static MoviePlay Instance;

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
#if UNITY_ANDROID || UNITY_IOS

		if (play) {
			Handheld.PlayFullScreenMovie("NASA - A View From The Other Side.mp4", Color.black, FullScreenMovieControlMode.CancelOnInput);
		} else {

		}
#else
		if (play) {
			((MovieTexture)GetComponent<Renderer> ().material.mainTexture).Play ();
			audio.Play ();		
		} else {
			((MovieTexture)GetComponent<Renderer>().material.mainTexture).Pause();
			audio.Pause ();
		}
#endif
	}

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

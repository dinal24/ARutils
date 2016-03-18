using UnityEngine;
using System.Collections;

public class DynamicCreation : MonoBehaviour {
	public Transform Meteor;

	void SpawnMeteor(){
		
		var enemeyTransform = Instantiate (Meteor) as Transform;
		enemeyTransform.position = new Vector3 (Random.Range(-200,200),650,Random.Range(-200,200));
		
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		float tf = Random.Range (0, 25);
		Debug.Log (tf);
		if (tf > 23) {
						Debug.Log ("IN");
						SpawnMeteor ();
		} else {
			Debug.Log("Out");				
		}
	}
}

using UnityEngine;
using System.Collections;

public class MeteorFall : MonoBehaviour {

	public ParticleSystem blastFx;
	public ParticleSystem fireFx;

	void Start () {
		rigidbody.velocity = Vector3.down * 200;
		Destroy (this, 10.0f);
	}

	void OnCollisionEnter(Collision collision){
		audio.Play ();
		gameObject.renderer.enabled = false;
		Explosion (gameObject.rigidbody.position);
		Debug.Log ("OnCol");
		gameObject.GetComponent<TrailRenderer>().enabled=false; 
		//Destroy (this, 5.0f);
	}

	private void Explosion(Vector3 position)
	{
		// Smoke 
		instantiate(blastFx, position);
		
		// Fire 
		instantiate(fireFx, position);
	}

	private ParticleSystem instantiate(ParticleSystem prefab, Vector3 position)
	{
		ParticleSystem newParticleSystem = Instantiate(
			prefab,
			position,
			Quaternion.identity
			) as ParticleSystem;
		
		//it will be destroyed
		Destroy(
			newParticleSystem.gameObject,
			newParticleSystem.startLifetime
			);
		
		return newParticleSystem;
	}

}

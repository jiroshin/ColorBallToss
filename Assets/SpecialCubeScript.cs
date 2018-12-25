using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpecialCubeScript : MonoBehaviour {

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
		
	}
	
	// Update is called once per frame
	void Update () {
		if (this.transform.position.y <= 1) {
			SceneManager.LoadScene("GameoverScene");
		}
		
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "redball") {
			other.transform.localScale = new Vector3 (0.9f, 0.9f, 0.9f);
			this.gameObject.GetComponent<ParticleSystem> ().Play ();
			audioSource.Play ();

		}else if(other.gameObject.tag == "blueball"){
			other.transform.localScale = new Vector3 (0.9f, 0.9f, 0.9f);
			this.gameObject.GetComponent<ParticleSystem> ().Play ();
			audioSource.Play ();

		}else if(other.gameObject.tag == "yellowball"){
			other.transform.localScale = new Vector3 (0.9f, 0.9f, 0.9f);
			this.gameObject.GetComponent<ParticleSystem> ().Play ();
			audioSource.Play ();

		}else if(other.gameObject.tag == "greenball"){
			other.transform.localScale = new Vector3 (0.9f, 0.9f, 0.9f);
			this.gameObject.GetComponent<ParticleSystem> ().Play ();
			audioSource.Play ();

		}else if(other.gameObject.tag == "whiteball"){
			other.transform.localScale = new Vector3 (0.9f, 0.9f, 0.9f);
			this.gameObject.GetComponent<ParticleSystem> ().Play ();
			audioSource.Play ();
		}

	}
		
}

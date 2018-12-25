using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class DestroyController : MonoBehaviour {

	private AudioSource audioSource;

	// Use this for initialization
	void Start () {
		audioSource = gameObject.GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update (){
		if (this.transform.position.y <= 1) {
			SceneManager.LoadScene("GameoverScene");
		}
	}

	void OnCollisionEnter(Collision other) {
		if (this.gameObject.tag == other.gameObject.tag) {
			other.transform.localScale = new Vector3 (0.9f, 0.9f, 0.9f);
			other.gameObject.GetComponent<ParticleSystem> ().Play ();
			audioSource.Play ();
		} 
	}
}

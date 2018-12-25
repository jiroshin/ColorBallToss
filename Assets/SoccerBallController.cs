using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SoccerBallController : MonoBehaviour {

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
		if (other.gameObject.tag == "soccerball") {
			audioSource.Play ();

			ParticleSystem particleSystem = GetComponent <ParticleSystem>();
			particleSystem.Play ();
			Destroy(this.gameObject, particleSystem.main.duration);
		}
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public int RingScore;
	public int PlayerScore;
	public AudioClip HitAudio;
	public AudioClip BombAudio;
	public AudioClip ScoreAudio;



	// Use this for initialization
	void Start () {

		RingScore = 0;
		PlayerScore = 0;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (RingScore == PlayerScore) {

			PlayerScore = PlayerScore + 1;
			RingScore = 0;
		
		}

		this.gameObject.GetComponentInChildren<TextMesh> ().text = RingScore.ToString ();
		
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.gameObject.tag == "Ball") {

			int hitballvalue = other.gameObject.GetComponent<ValueGenerator> ().ballvalue;

			RingScore = RingScore + hitballvalue;

			this.gameObject.GetComponent<AudioSource> ().clip = HitAudio;
			this.gameObject.GetComponent<AudioSource> ().Play ();

			Destroy (other.gameObject);

		}

		if (other.gameObject.name == "Bomb(Clone)") {

			this.gameObject.GetComponent<AudioSource> ().clip = BombAudio;
			this.gameObject.GetComponent<AudioSource> ().Play ();
		
		}

	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour {

	public int RingScore;
	public int PlayerScore;
	public AudioClip HitAudio;
	public AudioClip BombAudio;
	public AudioClip ScoreAudio;
	public GameObject Score;



	// Use this for initialization
	void Start () {

		RingScore = 0;
		PlayerScore = 1;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (RingScore == PlayerScore) {

			PlayerScore = PlayerScore + 1;
			RingScore = 0;
			this.gameObject.GetComponent<AudioSource> ().clip = ScoreAudio;
			this.gameObject.GetComponent<AudioSource> ().Play ();
		
		}

		if (RingScore > PlayerScore) {
			
			PlayerPrefs.SetInt("FinalScore",PlayerScore);
			SceneManager.LoadScene (2);

		}

		this.gameObject.GetComponentInChildren<TextMesh> ().text = RingScore.ToString ();
		Score.gameObject.GetComponentInChildren<TextMesh> ().text = "Score:"+ PlayerScore.ToString ();

		
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

			Destroy (other.gameObject);

			PlayerPrefs.SetInt("FinalScore",PlayerScore);

			SceneManager.LoadScene (2);
		
		}

	}
}

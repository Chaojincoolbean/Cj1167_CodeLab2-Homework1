using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class play_button : MonoBehaviour {

	public AudioSource audiosrc;

	void Start () {
		
		audiosrc = GetComponent<AudioSource>();
	}

	void Update () {
	

		if (Input.GetKeyDown (KeyCode.R)) {

			audiosrc.Play();
			SceneManager.LoadScene (1);
		}
			
	}


}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FinalScore : MonoBehaviour {

	public int score;

	// Use this for initialization
	void Start () {

		score = PlayerPrefs.GetInt ("FinalScore");

		this.gameObject.GetComponent<TextMesh> ().text = "Score: " + score;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

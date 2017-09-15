using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueGenerator : MonoBehaviour {

	public int ballvalue;
	public GameObject Ring;
	public int Score;
	public int EasyGravity;
	public int HardGravity;

	// Use this for initialization
	void Start () {

		Ring = GameObject.Find ("Ring");

		Score = Ring.gameObject.GetComponent<ScoreManager> ().PlayerScore;

		EasyGravity = 2;
		HardGravity = 100;

		if (Score == 1) {
			
			ballvalue = 1;
		} 

		else if (Score > 1) {
			
			ballvalue = Random.Range (1, 5);
			this.gameObject.GetComponent<Rigidbody2D> ().gravityScale = EasyGravity;
		
		}

		else if (Score > 10) {

			ballvalue = Random.Range (1, Score/2);

			this.gameObject.GetComponent<Rigidbody2D> ().gravityScale = HardGravity;
		}

		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.GetComponentInChildren<TextMesh> ().text = ballvalue.ToString ();
		
	}
}

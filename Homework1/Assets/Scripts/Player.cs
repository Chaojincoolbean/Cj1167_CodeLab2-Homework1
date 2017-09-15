using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float x;
	public float DragForce;
	public float AccelForce;
	public Rigidbody2D rb;


	// Use this for initialization
	void Start () {

		x = this.gameObject.transform.position.x;
		rb = GetComponent<Rigidbody2D> ();
		
	}

	
	// Update is called once per frame
	void Update () {

		rb.velocity *= DragForce;

		if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow)){
			rb.velocity += AccelForce * Vector2.left;
		}
		if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)){
			rb.velocity += AccelForce * Vector2.right;
		}
			

		if(Input.GetKey(KeyCode.Space)){

			this.gameObject.GetComponent<ScoreManager> ().RingScore = 0;
		
		}
	}
}

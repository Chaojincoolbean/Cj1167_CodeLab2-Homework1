using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

	public float x;

	// Use this for initialization
	void Start () {

		x = this.gameObject.transform.position.x;
		
	}

	
	// Update is called once per frame
	void Update () {

		if(Input.GetKey(KeyCode.A)||Input.GetKey(KeyCode.LeftArrow)){
			x = x - 0.3f;
		}
		if(Input.GetKey(KeyCode.D)||Input.GetKey(KeyCode.RightArrow)){
			x = x + 0.3f;
		}

		this.gameObject.transform.position = new Vector3 (x, this.gameObject.transform.position.y, this.gameObject.transform.position.z);
	}
}

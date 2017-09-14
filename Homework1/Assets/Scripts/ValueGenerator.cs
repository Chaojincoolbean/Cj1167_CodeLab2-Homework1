using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValueGenerator : MonoBehaviour {

	public int ballvalue;

	// Use this for initialization
	void Start () {

		ballvalue = 10;
		
	}
	
	// Update is called once per frame
	void Update () {

		this.transform.GetComponentInChildren<TextMesh> ().text = ballvalue.ToString ();
		
	}
}

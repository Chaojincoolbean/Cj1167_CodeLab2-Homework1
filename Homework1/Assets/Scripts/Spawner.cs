using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public Sprite[] sprites;

	// Use this for initialization
	void Start () {
		
		InvokeRepeating ("SpriteTime", 1, 1);
		
	}
	
	// Update is called once per frame
	void Update () {

		
	}

	void SpriteTime(){

		int nexNum = GetComponent<NumberGenerator>().Next ();

		MakeSprite (nexNum);

	
	}

	void MakeSprite(int num){
		
		GameObject goSprite = new GameObject ();

		SpriteRenderer sr = goSprite.AddComponent<SpriteRenderer> ();
		sr.sprite = sprites [num];

		goSprite.AddComponent<Rigidbody2D> ();
	
	}
}

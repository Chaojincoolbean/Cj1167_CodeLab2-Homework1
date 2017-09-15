using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

	public GameObject[] balls;
	public GameObject newBall;
	public float x;
	public float SpawnSpeed;

	// Use this for initialization
	void Start () {
		
		
		InvokeRepeating ("SpriteTime", 1, SpawnSpeed);
		x = 0f;
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

	void SpriteTime(){

		int nexNum = GetComponent<NumberGenerator>().Next ();

		MakeSprite (nexNum);

	
	}

	void MakeSprite(int num){

		x = Random.Range (-6, 6);

		newBall = balls [num];


		GameObject Ball = Instantiate(newBall, new Vector3(x, 5.54f,0), Quaternion.identity) as GameObject;

	
	}
}

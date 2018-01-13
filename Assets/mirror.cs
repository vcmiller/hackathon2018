using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SBR;

public class mirror : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		SpriteRenderer sprite = GetComponent<SpriteRenderer> ();
		CharacterMotor2D character = GetComponent<CharacterMotor2D> ();
		float dir = character.velocity.x;
		if (dir < 0)
			sprite.flipX = true;
		else if(dir > 0)
			sprite.flipX = false;

	}
}

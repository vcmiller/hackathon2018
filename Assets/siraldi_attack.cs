using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SBR;

public class siraldi_attack : BasicMotor<CharacterChannels> {

	// Use this for initialization


	public override void TakeInput(){

		LineRenderer beam = GetComponentInChildren<LineRenderer> ();
		SpriteRenderer sprite = GetComponent<SpriteRenderer> ();

		RaycastHit2D obj = Physics2D.Raycast (transform.position, sprite.flipX ? new Vector2 (-1, 0) : new Vector2 (1, 0));
		float True = 9999.9f;
		if (obj) {
			True = obj.distance;
		}
		if (channels.attack) { 
			if(sprite.flipX)
				beam.SetPosition (1, new Vector3 (-True, 0, 0));
			else
				beam.SetPosition (1, new Vector3 (True, 0, 0));
			
		}
		else
			beam.SetPosition (1, new Vector3 (1, 0, 0));
	}

}

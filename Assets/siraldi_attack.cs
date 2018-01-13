using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SBR;

public class siraldi_attack : BasicMotor<CharacterChannels> {

	// Use this for initialization


	public override void TakeInput(){

		LineRenderer beam = GetComponentInChildren<LineRenderer> ();
		SpriteRenderer sprite = GetComponent<SpriteRenderer> ();

		if (channels.attack) { 
			if(sprite.flipX)
				beam.SetPosition (1, new Vector3 (-9, 0, 0));
			else
				beam.SetPosition (1, new Vector3 (9, 0, 0));
			
		}
		else
			beam.SetPosition (1, new Vector3 (1, 0, 0));
	}

}

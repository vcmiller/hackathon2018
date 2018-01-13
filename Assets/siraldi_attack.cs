using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SBR;

public class siraldi_attack : BasicMotor<CharacterChannels> {

	// Use this for initialization
	void Start () {
		
	}

	public override void TakeInput(){
		print ("here");

		LineRenderer beam = GetComponentInChildren<LineRenderer> ();

		if (channels.attack) { 
			beam.SetPosition (1, new Vector3 (9, 0, 0));
			print("in honor of vincent: asdf");
		}
		else
			beam.SetPosition (1, new Vector3 (1, 0, 0));
	}

}

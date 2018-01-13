using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SBR;

public class sirvatious_attack : BasicMotor<CharacterChannels> {

	public GameObject projectile; 

	public float coolDownnnn;
	public float remainingCooldownnn;

	public override void TakeInput(){
		SpriteRenderer sprite = GetComponent<SpriteRenderer> ();

		remainingCooldownnn -= Time.deltaTime;

		if (channels.attack && remainingCooldownnn <= 0) { 

			GameObject newProjectitle = Instantiate (projectile, transform.position, Quaternion.identity);

			remainingCooldownnn = coolDownnnn;

			if (sprite.flipX) {
				Projectile projectile = newProjectitle.GetComponent<Projectile> ();
				projectile.Fire (new Vector2 (-1, 0));
                projectile.velocity += (Vector3)GetComponent<CharacterMotor2D>().velocity;
			} else {
				Projectile projectile = newProjectitle.GetComponent<Projectile> ();
				projectile.Fire (new Vector2 (1, 0));
                projectile.velocity += (Vector3)GetComponent<CharacterMotor2D>().velocity;
            }

            

		}

	}
}

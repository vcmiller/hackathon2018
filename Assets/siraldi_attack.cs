using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SBR;

public class siraldi_attack : BasicMotor<CharacterChannels> {
    private CooldownTimer shootCooldownTimer;
    private ExpirationTimer shootDurTimer;

    public float shootCooldown = 2;
    public float shootDur = 0.78123f;

    protected override void Start() {
        base.Start();

        shootCooldownTimer = new CooldownTimer(shootCooldown);
        shootDurTimer = new ExpirationTimer(shootDur);
    }

    // Use this for initialization
    public float dps = 2;

	public override void TakeInput(){

		LineRenderer beam = GetComponentInChildren<LineRenderer> ();
		SpriteRenderer sprite = GetComponent<SpriteRenderer> ();

        if (channels.attack && shootCooldownTimer.Use()) {
            shootDurTimer.Set();
        }

        if (!shootDurTimer.expired) { 
            RaycastHit2D obj = Physics2D.Raycast(transform.position, sprite.flipX ? new Vector2(-1, 0) : new Vector2(1, 0));
            float True = 9999.9f;
            if (obj) {
                True = obj.distance;
                var health = obj.collider.GetComponent<Health>();

                if (health) {
                    health.ApplyDamage(new Damage(dps * Time.deltaTime, obj.point, obj.normal));
                }
            }

            if (sprite.flipX)
				beam.SetPosition (1, new Vector3 (-True, 0, 0));
			else
				beam.SetPosition (1, new Vector3 (True, 0, 0));
			
		}
		else
			beam.SetPosition (1, new Vector3 (1, 0, 0));
	}

}

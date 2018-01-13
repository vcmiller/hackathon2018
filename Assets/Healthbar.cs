using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SBR;

public class Healthbar : MonoBehaviour {
    private Slider slider { get; set; }

    public Health health;

	// Use this for initialization
	void Start () {
        slider = GetComponent<Slider>();
	}
	
	// Update is called once per frame
	void Update () {
        slider.value = health.health / health.maxHealth;
	}
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayerOnContact : MonoBehaviour {

    public int damageToGive;

    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter(Collider other) {
        if (other.name == "Player") {
            HealthManager.HurtPlayer(damageToGive);
        }
    }
}
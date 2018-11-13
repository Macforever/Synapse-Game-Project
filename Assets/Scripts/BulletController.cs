﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed;
    public PlayerController player;
    public GameObject enemyDeathEffect;
    public GameObject implactEffect;

    public int pointsForKill;



	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        if(player.transform.localScale.x < 0) {
            speed = -speed;
        }
    }
	
	// Update is called once per frame
	void Update () {
        GetComponent<Rigidbody>().velocity = new Vector3(speed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);

	}

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy") {
            Instantiate(enemyDeathEffect, other.transform.position, other.transform.rotation);
            Destroy(other.gameObject);
            ScoreManager.AddPoints(pointsForKill);
        }
        Instantiate(implactEffect, transform.position, transform.rotation);
        Destroy(gameObject);

        
    }
}
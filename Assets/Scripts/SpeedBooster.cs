using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour {
    public int newSpeed;
    private float oldSpeed;
    public float boostTime;
    private PlayerController playerController;

    void Start() {

        playerController = FindObjectOfType<PlayerController>();

    }


    private void OnTriggerEnter(Collider other) {

        if (other.GetComponent<PlayerController>() != null) {
            Debug.Log("Picked SpeedBooster");
            Destroy(gameObject);
            playerController.BoostSpeed(boostTime, newSpeed);

        }
    }



}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedBooster : MonoBehaviour {
    public int newSpeed;
    private float oldSpeed;
    public float boostTime;
    public PlayerController playerController;

    void Start() {
       // playerController = GetComponent<PlayerController>();

    }


    private void OnTriggerEnter(Collider other) {

        if (other.GetComponent<PlayerController>() != null) {
            Debug.Log("Picked SpeedBooster");
            oldSpeed = playerController.moveSpeed;
            playerController.moveSpeed = newSpeed;
            Destroy(gameObject);
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay() {
        yield return new WaitForSeconds(boostTime);
        playerController.moveSpeed = oldSpeed;
    }

}

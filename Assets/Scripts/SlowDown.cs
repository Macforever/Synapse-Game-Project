using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowDown : MonoBehaviour {
    public int newSpeed;
    private float normalSpeed;
    private PlayerController playerController;

    void Start() {
        playerController = FindObjectOfType<PlayerController>();
        normalSpeed = playerController.moveSpeed;

    }


    private void OnTriggerEnter(Collider other) {
        if (other.GetComponent<PlayerController>() != null) {
            Debug.Log("SlowDown underground");
            playerController.moveSpeed = newSpeed;
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.GetComponent<PlayerController>() != null) {
            playerController.moveSpeed = normalSpeed;
        }
    }
}

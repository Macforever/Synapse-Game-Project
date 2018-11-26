using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    private PlayerController playerController;

    // Use this for initialization
    void Start () {
        playerController = FindObjectOfType<PlayerController>();

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(KeyCode.D)) {
            playerController.MoveForward(true);
        }
        if (Input.GetKey(KeyCode.A)) {
            playerController.MoveForward(false);
        }
    }
}

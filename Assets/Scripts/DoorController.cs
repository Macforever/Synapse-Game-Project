using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour {

    public Vector3 teleportPoint;
    public Rigidbody rb;

    private KeyManager keyManager;

    // Use this for initialization
    void Start() {
        rb = GetComponent<Rigidbody>();
        keyManager = FindObjectOfType<KeyManager>();
    }

    private void OnTriggerStay(Collider other) {
        print("Player entered Trigger Zone");

        if (other.GetComponent<PlayerController>() != null && keyManager.GetFoundKeys() == 5) {
            print("Door opens");
            rb.MovePosition(teleportPoint);
        } else {
            print("Not enough Keys");
        }

    } 
}

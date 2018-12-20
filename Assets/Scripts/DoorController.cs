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

    private void OnTriggerEnter(Collider other) {
        if (other.name == "Player" && keyManager.GetFoundKeys() == 5) {
            rb.MovePosition(transform.position + transform.forward * Time.deltaTime);
        }
    } 
}

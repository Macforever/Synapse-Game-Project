using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickUp : MonoBehaviour {

    private KeyManager keyManager;

    void Start() {
        keyManager = FindObjectOfType<KeyManager>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<PlayerController>() != null) {
            Debug.Log("Picked up Key");
            keyManager.addKeyToInventory(1);
            Destroy(gameObject);
        }
    }
}

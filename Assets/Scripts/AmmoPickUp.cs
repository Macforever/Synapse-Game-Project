using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour {

    public int pointsToAdd;
    private AmmoManager ammoManager;

    void Start() {
        ammoManager = FindObjectOfType<AmmoManager>();
    }


    private void OnTriggerEnter(Collider other) {

        if (other.GetComponent<PlayerController>() != null) {
            Debug.Log("Picked up Ammo");
            ammoManager.IncreaseAmmo(pointsToAdd);
            Destroy(gameObject);
        }

    }
}

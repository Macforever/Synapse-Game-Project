using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickUp : MonoBehaviour {

    public int pointsToAdd;

    private void OnTriggerEnter(Collider other) {

        if (other.GetComponent<PlayerController>() != null) {
            Debug.Log("Picked up Ammo");
            AmmoManager.IncreaseAmmo(pointsToAdd);
            Destroy(gameObject);
        }

    }
}

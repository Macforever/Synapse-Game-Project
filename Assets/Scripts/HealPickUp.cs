using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealPickUp : MonoBehaviour {

    public int pointsToAdd;

    private void OnTriggerEnter(Collider other) {

        if (other.GetComponent<PlayerController>() != null) {
            Debug.Log("Picked up Heal");
            HealthManager.GiveHeal(pointsToAdd);
            //ScoreManager.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }

    }
}

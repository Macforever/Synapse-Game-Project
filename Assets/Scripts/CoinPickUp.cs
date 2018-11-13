using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinPickUp : MonoBehaviour {

    public int pointsToAdd;

    private void OnTriggerEnter(Collider other) {

        if (other.GetComponent<PlayerController>() != null) {
            Debug.Log("Add Points");
            ScoreManager.AddPoints(pointsToAdd);
            Destroy(gameObject);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtPlayerOnContact : MonoBehaviour {

    public int damageToGive;
    public GameObject hurtParticles;

    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void Update() {

    }
    private void OnTriggerEnter(Collider other) {
        if (other.name == "Player") {
            HealthManager.HurtPlayer(damageToGive);

            Instantiate(hurtParticles, other.transform.position, other.transform.rotation);

            var player = other.GetComponent<PlayerController>();
            player.knockbackCount = player.knockbackLength;

            if (other.transform.position.x < transform.position.x) {
                player.knockFromRight = true;
            }
            else {
                player.knockFromRight = false;
            }
        }
    }
}


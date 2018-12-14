using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour {

    public float speed;
    public PlayerController player;
    public GameObject enemyDeathEffect;
    public GameObject implactEffect;
    public float destroytime;


    public int pointsForKill;

    public int damageToGive;



	// Use this for initialization
	void Start () {
        player = FindObjectOfType<PlayerController>();

        if(player.transform.localScale.x < 0) {
            speed = -speed;
        }
    }
	
	// Update is called once per frame
	void Update () {

        GetComponent<Rigidbody>().velocity = new Vector3(speed, GetComponent<Rigidbody>().velocity.y, GetComponent<Rigidbody>().velocity.z);
        Destroy(gameObject, destroytime);
    }

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy") {
            other.GetComponent<EnemyHealthManager>().giveDamage(damageToGive);
        }
        if (other.tag == "Player") {
            return;
        }
        Instantiate(implactEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHealthManager : MonoBehaviour {
    public int enemyHealth;

    public GameObject deathEffect;

    public int PointsOnDeath;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if(enemyHealth <= 0) {
            Instantiate(deathEffect, transform.position, transform.rotation);
            ScoreManager.AddPoints(PointsOnDeath);
            Destroy(gameObject);
            Debug.Log("Er ist tot Jim.");
        }
	}
    public void giveDamage(int ammountOfDamage) {
        enemyHealth -= ammountOfDamage;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HurtEnemyOnContact : MonoBehaviour {

    public int dmgToGive;
    public float bounceOnEnemy;
    private Rigidbody myRigidbody;


	// Use this for initialization
	void Start () {
        myRigidbody = transform.parent.GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Enemy") {
            other.GetComponent<EnemyHealthManager>().giveDamage(dmgToGive);
            myRigidbody.velocity = new Vector3(myRigidbody.velocity.x, bounceOnEnemy);
        }
        
    }
}

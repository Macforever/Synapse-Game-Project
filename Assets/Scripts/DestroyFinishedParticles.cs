using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFinishedParticles : MonoBehaviour {

    private ParticleSystem aktualParticleSystem;

	// Use this for initialization
	void Start () {
        aktualParticleSystem = GetComponent<ParticleSystem>();
	}
	
	// Update is called once per frame
	void Update () {
        if (aktualParticleSystem.isStopped) {
            Destroy(gameObject); 
        }
	}
    private void OnBecameInvisible() {
        Destroy(gameObject);
    }
}

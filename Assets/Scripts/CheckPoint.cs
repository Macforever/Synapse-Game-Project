using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckPoint : MonoBehaviour {

    public LevelManager levelManager;


    // Use this for initialization
    void Start() {
        levelManager = FindObjectOfType<LevelManager>();
    }

    // Update is called once per frame
    void Update () {

	}
    private void OnTriggerEnter(Collider other) {
        if (other.name == "Player") {
            levelManager.currentCheckPoint = gameObject;
            Debug.Log("Activated Chechpoint " + levelManager.currentCheckPoint.name);
        }
    }
}

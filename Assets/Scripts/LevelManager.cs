using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject spawnPoint;
    private PlayerController player;
    

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void RespawnPlayer() {
        Debug.Log("Player Respawn");
        player.transform.position = spawnPoint.transform.position;
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour {

    public GameObject currentCheckPoint;
    private PlayerController player;

    public GameObject deathParticles;
    public GameObject respawnParticles;

    public int PointPenaltyOnDeath;

    public float respawnDelay;

    private CameraController mycamera;

    public HealthManager healthManager;



    // Use this for initialization
    void Start() {
        player = FindObjectOfType<PlayerController>();

        mycamera = FindObjectOfType<CameraController>();

        healthManager = FindObjectOfType<HealthManager>();

    }

    // Update is called once per frame
    void Update() {

    }
    public void RespawnPlayer() {
        StartCoroutine("RespawnPlayerCo");
    }

    public IEnumerator RespawnPlayerCo() {
        Instantiate(deathParticles, player.transform.position, player.transform.rotation);
        player.enabled = false;
        player.GetComponent<Renderer>().enabled = false;
        mycamera.isFollowing = false;
        //player.GetComponent<Rigidbody>().useGravity = false;
        //player.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ScoreManager.AddPoints(-PointPenaltyOnDeath);
        Debug.Log("Player Respawn");
        yield return new WaitForSeconds(respawnDelay);
        player.transform.position = currentCheckPoint.transform.position;
        player.enabled = true;
        player.GetComponent<Renderer>().enabled = true;
        healthManager.FullHealth();
        healthManager.isDeath = false;
        mycamera.isFollowing = true;
        //player.GetComponent<Rigidbody>().useGravity = true;
        Instantiate(respawnParticles, currentCheckPoint.transform.position, currentCheckPoint.transform.rotation);
    }
}

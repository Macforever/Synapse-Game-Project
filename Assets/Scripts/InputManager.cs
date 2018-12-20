using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InputManager : MonoBehaviour {
 
    private PlayerController playerController;
    public Shoot shoot;
    public Melee melee;

    // Use this for initialization
    void Start () {
        playerController = FindObjectOfType<PlayerController>();
    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKey(KeyCode.D)) {
            playerController.MoveForward(true);
        }
        if (Input.GetKey(KeyCode.A)) {
            playerController.MoveForward(false);
        }
        if (Input.GetKeyDown(KeyCode.Return)) {
            shoot.shootBullet();
        }
        if (Input.GetKeyDown(KeyCode.M)) {
            melee.stabbing();
        }
        if (Input.GetKeyDown(KeyCode.Space)) {
            playerController.jumpManager();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Debug.Log("Holt mich hier Raus!");
            SceneManager.LoadScene(0);
        }

    }
}

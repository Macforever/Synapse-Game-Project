using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.

public class HealthManager : MonoBehaviour {
    public TextMeshProUGUI myHealthText;

    public int maxPlayerHealth;
    public static int playerHealth;

    private LevelManager levelmanager;

    public bool isDeath;


    // Use this for initialization
    void Start() {
        FullHealth();
        myHealthText = FindObjectOfType<TextMeshProUGUI>();
        levelmanager = FindObjectOfType<LevelManager>();
        isDeath = false;

    }

    // Update is called once per frame
    void Update() {
        if (playerHealth <= 0 && !isDeath) {
            //playerHealth = 0;
            levelmanager.RespawnPlayer();
            isDeath = true;
        }


        if (myHealthText.tag == "HealthPointsScreen") {
            myHealthText.text = "Health: " + playerHealth;
        }

    }
    public static void HurtPlayer(int damageToGive) {
        playerHealth -= damageToGive;
    }
    public void FullHealth() {
        playerHealth = maxPlayerHealth;
    }
}

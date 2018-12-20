using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour {
    public TextMeshProUGUI myHealthScreen;
    public TextMeshProUGUI myLiveScreen;

    public int maxPlayerHealth;
    public static int playerHealth;

    private LevelManager levelmanager;

    public bool isDeath;
    public int extraLives;


    // Use this for initialization
    void Start() {
        FullHealth();
       // myHealthText = FindObjectOfType<TextMeshProUGUI>();
        levelmanager = FindObjectOfType<LevelManager>();
        isDeath = false;

    }

    // Update is called once per frame
    void Update() {
        if (playerHealth <= 0 && !isDeath) {
            //playerHealth = 0;

            if (extraLives >= 1) {
                extraLives--;
                levelmanager.RespawnPlayer();
                isDeath = true;
            }
            else {
                SceneManager.LoadScene(2);
            }
        }

        if (myHealthScreen.tag == "HealthPointsScreen") {
            myHealthScreen.text = "Health: " + playerHealth;
        }
        if (myLiveScreen.tag == "Lives") {
            myLiveScreen.text = "Lives: " + extraLives;
        }



    }
    public static void HurtPlayer(int damageToGive) {
        playerHealth -= damageToGive;
    }
    public static void GiveHeal(int healtAmmount) {
        playerHealth += healtAmmount;
    }
    public void FullHealth() {
        playerHealth = maxPlayerHealth;
    }
}

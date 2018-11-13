using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.

public class ScoreManager : MonoBehaviour {
    public static int score = 0;
    public TextMeshProUGUI myText;

    void Start() {

        myText = FindObjectOfType<TextMeshProUGUI>();


    }
    void Update() {

        if (score < 0) {
            score = 0;
        }
        if (myText.tag == "GameScoreScreen") {
            myText.text = "Score: " + score;
        }
    }


    public static void AddPoints(int pointsToAdd) {
        score += pointsToAdd;
    }
    public static void ResetScore() {
        score = 0;
    }



}



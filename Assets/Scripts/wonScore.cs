using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.

public class wonScore : MonoBehaviour {
    public TextMeshProUGUI myScore;
    public static int hScore;
    

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Debug.Log("Deathscore2: " + hScore);
        if (myScore.tag == "deathscore") {
            myScore.text = "Score: " + hScore;
        }

    }
    public void SetScore(int score) {
        hScore = score;
    }

}

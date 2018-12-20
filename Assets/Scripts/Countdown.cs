using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.
using UnityEngine.SceneManagement;

public class Countdown : MonoBehaviour {
    public TextMeshProUGUI timeLeftScreen;
    public int timeLeft; //Seconds Overall

    // Use this for initialization
    void Start() {
        StartCoroutine("LoseTime");
        Time.timeScale = 1; //Just making sure that the timeScale is right

    }

    // Update is called once per frame
    void Update() {
        if (timeLeftScreen.tag == "TimeLeft") {
            timeLeftScreen.text = "TimeLeft: " + timeLeft;
        }

    }
    IEnumerator LoseTime() {
        while (timeLeft >= 0) {
            yield return new WaitForSeconds(1);
            timeLeft--;
        }
        SceneManager.LoadScene(2);


    }
}

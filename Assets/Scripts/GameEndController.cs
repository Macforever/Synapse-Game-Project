using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;




public class GameEndController : MonoBehaviour {
    // Use this for initialization
    void Start() {

    }

    private void OnTriggerStay(Collider other) {
        if (other.GetComponent<PlayerController>() != null) {
            //give highscore on winScript:
            Debug.Log("Deathscore: "+ScoreManager.score);
            wonScore.hScore = ScoreManager.score ;
            SceneManager.LoadScene(3);
        }

    }
}

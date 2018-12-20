using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEndController : MonoBehaviour {

    private void OnTriggerStay(Collider other) {
        if (other.GetComponent<PlayerController>() != null) {
            SceneManager.LoadScene(2);
        }

    }
}

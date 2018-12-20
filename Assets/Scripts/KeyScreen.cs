using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyScreen : MonoBehaviour {

    public TextMeshProUGUI myScreenKeys;
    private KeyManager keyManager;

    // Use this for initialization
    void Start() {
        keyManager = FindObjectOfType<KeyManager>();
    }

    // Update is called once per frame
    void Update() {
        if (myScreenKeys.tag == "KeysFoundScreen") {
            myScreenKeys.text = "Keys: " + keyManager.GetFoundKeys() + "/5";
        }

    }
}

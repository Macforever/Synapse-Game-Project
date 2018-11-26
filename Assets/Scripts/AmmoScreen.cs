using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; // Add the TextMesh Pro namespace to access the various functions.

public class AmmoScreen : MonoBehaviour {
    public TextMeshProUGUI myScreenAmmo;

    // Use this for initialization
    void Start () {
        myScreenAmmo = FindObjectOfType<TextMeshProUGUI>();

    }
	
	// Update is called once per frame
	void Update () {
        if (myScreenAmmo.tag == "CurrentAmmoScreen") {
            myScreenAmmo.text = "Ammo: " + AmmoManager.currentAmmo;
        }

    }
}

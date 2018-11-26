using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoManager : MonoBehaviour {
    public int maxAmmo;
    public static int currentAmmo;

	// Use this for initialization
	void Start () {
        currentAmmo = maxAmmo;
	}
	
    public int GetCurrentAmmo() {
        return currentAmmo;
    }
    public static void IncreaseAmmo(int value) {
        currentAmmo += value;
    }
    public static void DecraseAmmo(int value) {
        currentAmmo -= value;
        if(currentAmmo < 0) {
            currentAmmo = 0;
        }
    }

}

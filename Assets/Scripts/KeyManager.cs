using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyManager : MonoBehaviour {

    private int playerKeys;

    // Use this for initialization
    void Start () {
        playerKeys = 0;
    }

    public int GetFoundKeys() {
        return playerKeys;
    }

    public void addKeyToInventory(int keyAmmount) {
        playerKeys += keyAmmount;
    }
}

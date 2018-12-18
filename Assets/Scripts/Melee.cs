using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Melee : MonoBehaviour {

    public float stabDelay;
    public GameObject sword;
    public Transform stabbingPoint;

    private bool canStab;

    void Start() {
        canStab = true;
    }


    public void stabbing()
    {
        if (canStab)
        {
            Instantiate(sword, stabbingPoint.position, stabbingPoint.rotation);
            canStab = false;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay()
    {
        yield return new WaitForSeconds(stabDelay);
        canStab = true;
    }
}

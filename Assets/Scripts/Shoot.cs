using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    private bool canShoot;
    public float shootDelay;
    public Transform firePoint;
    public GameObject bullet;
    private AmmoManager ammoManager;

    void Start() {
        ammoManager = FindObjectOfType<AmmoManager>();
        canShoot = true;
    }


    public void shootBullet() {
        if (canShoot && ammoManager.GetCurrentAmmo() >= 1) {

            Instantiate(bullet, firePoint.position, firePoint.rotation);
            canShoot = false;
            StartCoroutine(Delay());
            ammoManager.DecraseAmmo(1);

        }
    }

    IEnumerator Delay() {
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }


}




using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {
    
    public bool hasInfiniteAmmo;
    public float shootDelay;
    public Transform firePoint;
    public GameObject bullet;

    private bool canShoot;
    private AmmoManager ammoManager;

    void Start() {
        ammoManager = FindObjectOfType<AmmoManager>();
        canShoot = true;
    }


    public void shootBullet() {
        if (!hasInfiniteAmmo) {
            if (canShoot && ammoManager.GetCurrentAmmo() >= 1) {
                Instantiate(bullet, firePoint.position, firePoint.rotation);
                canShoot = false;
                StartCoroutine(Delay());
                ammoManager.DecraseAmmo(1);
            }
        } else if (canShoot) {
            Instantiate(bullet, firePoint.position, firePoint.rotation);
            canShoot = false;
            StartCoroutine(Delay());
        }
    }

    IEnumerator Delay() {
        yield return new WaitForSeconds(shootDelay);
        canShoot = true;
    }


}




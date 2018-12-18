using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerPatrol : MonoBehaviour {

    public Transform target;
    public Shoot shoot;

    public float offset;
    public float rotationSpeed;
    public float towerRange;
    public float maxRotationClockwise;
    public float maxRotationCounterClockwise;

    private bool inRange;
    private bool rotationClockwise;
    private Vector3 targetPos;
    private Vector3 thisPos;
    private float angle;
    private float rotationPos;

    // Use this for initialization
    void Start () {
        SphereCollider sc = new SphereCollider();
        sc = this.gameObject.AddComponent<SphereCollider>();
        sc.radius = towerRange;
        sc.isTrigger = true;
        sc.tag = "FireZone";
        inRange = false;
    }
	
	// Update is called once per frame
	void Update () {
        if (inRange) {
            // Rotate the camera every frame so it keeps looking at the target
            targetPos = target.position;
            thisPos = transform.position;
            targetPos.x = targetPos.x - thisPos.x;
            targetPos.y = targetPos.y - thisPos.y;
            angle = Mathf.Atan2(targetPos.y, targetPos.x) * Mathf.Rad2Deg;
            rotationPos = angle + offset;
            if (rotationPos > maxRotationClockwise && rotationPos < maxRotationCounterClockwise)
            {
                transform.rotation = Quaternion.Euler(new Vector3(0, 0, rotationPos));
            }

            shoot.shootBullet();
        }
    }

    void OnTriggerEnter(Collider other) {
        inRange = true;
    }

    void OnTriggerExit(Collider other) {
        inRange = false;
    }
}


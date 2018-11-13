using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour {

    public float moveSpeed;
    private bool moveRight;

    public Transform wallCheck;
    public float wallCheckRadius;
    public LayerMask whatIsWall;
    private bool hittingWall;

    private bool notAtEdge;
    public Transform edgeCheck;



    // Use this for initialization
    void Start() {


    }

    // Update is called once per frame
    void Update() {


        var hitColliders = Physics.OverlapSphere(wallCheck.position, wallCheckRadius, whatIsWall);
        this.hittingWall = (hitColliders.Length > 0) ? true : false;

        var edgeColliders = Physics.OverlapSphere(edgeCheck.position, wallCheckRadius, whatIsWall);
        this.notAtEdge = (edgeColliders.Length > 0) ? true : false;


        if (hittingWall || !notAtEdge) {
            moveRight = !moveRight;
        }


        if (moveRight) {
            transform.localScale = new Vector3(-1f, 1f, 1f);
            GetComponent<Rigidbody>().velocity = new Vector3(moveSpeed, GetComponent<Rigidbody>().velocity.y, 0);
        }
        else {
            transform.localScale = new Vector3(1f, 1f, 1f);
            GetComponent<Rigidbody>().velocity = new Vector3(-moveSpeed, GetComponent<Rigidbody>().velocity.y, 0);
        }

    }
}

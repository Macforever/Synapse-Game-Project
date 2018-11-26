using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float moveSpeed;
    private float moveVelocity;
    public float jumpHeight;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask whatIsGround;
    private bool grounded;

    private bool doubleJump;

    public Transform firePoint;
    public GameObject bullet;
    private AmmoManager ammoManager;


    void Start() {
        ammoManager = FindObjectOfType<AmmoManager>();

    }

    private void FixedUpdate() {

        var hitColliders = Physics.OverlapSphere(groundCheck.position, groundCheckRadius, whatIsGround);
        this.grounded = (hitColliders.Length > 0) ? true : false;
        GetComponent<Rigidbody>().AddForce(Physics.gravity * (GetComponent<Rigidbody>().mass * GetComponent<Rigidbody>().mass));
    }

    void Update() {

        if (Input.GetKeyDown(KeyCode.Space) && this.grounded) {
            Jump();
            doubleJump = true;
        }
        if ((Input.GetKeyDown(KeyCode.Space)) && doubleJump && !grounded) {
            Jump();
            doubleJump = false;
        }

        moveVelocity = 0f;

        if (Input.GetKey(KeyCode.D)) {
            //MoveForward();
            //GetComponent<Rigidbody>().velocity = new Vector3(moveSpeed, GetComponent<Rigidbody>().velocity.y, 0);
            moveVelocity = moveSpeed;
        }
        if (Input.GetKey(KeyCode.A)) {
            // MoveBackwards();
            //GetComponent<Rigidbody>().velocity = new Vector3(-moveSpeed, GetComponent<Rigidbody>().velocity.y, 0);
            moveVelocity = -moveSpeed;
        }
        GetComponent<Rigidbody>().velocity = new Vector3(moveVelocity, GetComponent<Rigidbody>().velocity.y, 0);


        if (Input.GetKeyDown(KeyCode.Return)) {
            if (ammoManager.GetCurrentAmmo() >= 1) {
                Instantiate(bullet, firePoint.position, firePoint.rotation);
                ammoManager.DecraseAmmo(1);
            }

        }
    }

    public void Jump() {
        GetComponent<Rigidbody>().velocity = new Vector3(GetComponent<Rigidbody>().velocity.x, jumpHeight, 0);
    }
}
